import "./Modal.css";


const Modal = ({children, isOpen, closeModal}) => {

return (
    <article className={`modal ${isOpen && "is-open"}`} onClick={closeModal}>
      <div onClick={e => {e.stopPropagation();}}className="modal-container"> 
        <button onClick={closeModal} className="modal-close">X</button>
       {children}</div> 
     </article>
    );
    
   }
export default Modal;

