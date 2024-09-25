
import { initializeApp } from "https://www.gstatic.com/firebasejs/9.23.0/firebase-app.js";
import { getAuth, signInWithEmailAndPassword, createUserWithEmailAndPassword } from "https://www.gstatic.com/firebasejs/9.23.0/firebase-auth.js";
import { getFirestore, collection, addDoc } from "https://www.gstatic.com/firebasejs/9.23.0/firebase-firestore.js";
import { setDoc, doc, getDoc } from "https://www.gstatic.com/firebasejs/9.23.0/firebase-firestore.js";

// Configuración de Firebase
const firebaseConfig = {
    apiKey: "AIzaSyBFtaKGHFOhLKXUOkM6WjI6XfBOb8qLwCw",
    authDomain: "blazor-web-countries.firebaseapp.com",
    projectId: "blazor-web-countries",
    storageBucket: "blazor-web-countries.appspot.com",
    messagingSenderId: "9229473950",
    appId: "1:9229473950:web:0e74178b3ff81dd734838f"
};

// Inicializar Firebase
const app = initializeApp(firebaseConfig);
const auth = getAuth(app);
const db = getFirestore(app); // Inicializa Firestore

// Función para iniciar sesión
window.loginWithEmailPassword = async function (email, password) {
    console.log("Intentando iniciar sesión con:", email, password);
    try {
        const userCredential = await signInWithEmailAndPassword(auth, email, password);
        return JSON.stringify(userCredential.user);
    } catch (error) {
        console.error("Error de inicio de sesión:", error);
        return JSON.stringify({ error: error.code, message: error.message });
    }
};

// Función para registrar un nuevo usuario
window.registerUser = async function (email, password, nombre, apellido, continente) {
    // Validaciones simples
    if (!email || !password || !nombre || !apellido || !continente) {
        return JSON.stringify({ error: 'Todos los campos son obligatorios.' });
    }
    try {
        const userCredential = await createUserWithEmailAndPassword(auth, email, password);
        const user = userCredential.user;

        const usuarioData = {
            Nombre: nombre,
            Apellidos: apellido,
            Continente: continente,
            IsAdmin: false,
            uid: user.uid // Cambié a "uid" en minúscula para mantener la consistencia
        };

        // Imprimir usuarioData en la consola
        console.log("Datos del usuario a guardar:", usuarioData);

        // Crear un documento con un ID específico (uid del usuario)
        await setDoc(doc(db, "Usuarios", user.uid), usuarioData);

        return JSON.stringify(user);
    } catch (error) {
        console.error("Error al registrar el usuario:", error); // Imprimir el error en la consola
        return JSON.stringify({ error: error.code, message: error.message });
    }
};

// Función para obtener un documento por ID
window.getDocumentById = async function (documentId) {
    try {
        const docRef = doc(db, "Usuarios", documentId);
        const docSnap = await getDoc(docRef);

        if (docSnap.exists()) {
            return JSON.stringify(docSnap.data());
        } else {
            console.log("No se encontró el documento");
            return JSON.stringify({ error: "No se encontró el documento" });
        }
    } catch (error) {
        console.error("Error al obtener el documento:", error);
        return JSON.stringify({ error: error.code, message: error.message });
    }
};
