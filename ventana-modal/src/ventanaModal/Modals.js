import Modal from "./Modal";
import { useModal } from "./usarModal";

const Modals = () => {
const[isOpenModal, openModal, closeModal] = useModal(false)
    return (
      <div >
      <h2>Hacer click en el boton</h2>
      <div>
        <div>
        <button onClick={openModal}>Ver foto de animal bonito</button></div>
       <Modal isOpen={isOpenModal} closeModal={closeModal}>
        <p>Este es el modal , tarde bastante</p>
        <img src="https://loremflickr.com/640/360" alt="animales" ></img>
       </Modal></div>
      </div>);
     }
  export default Modals;
  
  




// export const App = ({ children,isOpen,closeModal }) => {
//     return (
//       <article className={`modal${isOpen && "is-open"}`}>
//         <div className="modal-container">
//           <h1>Ventana</h1>
//           <button onClick={openModal}>Abrir ventana modal</button>
//           <Modal>
//           </Modal> 
//         </div>
//       </article>
//     );
//   };
  
  