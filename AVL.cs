using System;

namespace tp3
{

	public class AVL{
		
		private IComparable dato;
		private AVL hijoIzquierdo;
		private AVL hijoDerecho;
		private int altura;
		
		public AVL(IComparable dato){
			this.dato = dato;
		}
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public AVL getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public AVL getHijoDerecho(){
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(AVL hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(AVL hijo){
			this.hijoDerecho=hijo;
		}
		
		public void eliminarHijoIzquierdo(){
			this.hijoIzquierdo=null;
		}
		
		public void eliminarHijoDerecho(){
			this.hijoDerecho=null;
		}
		
		public AVL agregar(IComparable elem) //era void 
		{
			//si elem es mayor que el dato almacenado en la raiz
			if (elem.CompareTo(this.getDatoRaiz()>0)) 
			{
				//si el hijo derecho est vacio inserto elem en ese lugar
				
				//si el arbol derecho No esta vacio,llamo recursivamente a agregar()
								
			}
			//si elem es menor o igual al dato almacenado en la raiz
			else
			{
				
			}
		}
		
		//rotacion simple derecha
		public AVl rotacionSimpleDerecha() 
		{
			//referencia a nueva raiz luego de la rotacion
			AVL nuevaRaiz=this.getHijoIzquierdo();
			
			//cambio hijo derecho de raiz actual
			this.agregarHijoDerecho(nuevaRaiz.getHijoIzquierdo());
			
			//cambiar hijo izquierdo de la nueva raiz
			nuevaRaiz.agregarHijoIzquierdo(this);
			
			//actualizar altura de antigua raiz(this)
			this.actualizarAltura();
			
			//actualizar altura de nueva raiz
			nuevaRaiz.actualizarAltura();
			
			//retornamos nueva raiz
			return nuevaRaiz;	
		}
		
		//rotacion simple con izquierdo
		public AVL rotacionSimpleIzquierda() //era public void 
		{
			//referencia a nueva raiz luego de la rotacion
			AVL nuevaRaiz=this.getHijoIzquierdo();
			
			//cambio hijo izquierdo de raiz actual
			this.agregarHijoIzquierdo(nuevaRaiz.getHijoDerecho());
			
			//cambiar hijo derecho de la nueva raiz
			nuevaRaiz.agregarHijoDerecho(this);
			
			//actualizar altura de antigua raiz(this)
			this.actualizarAltura();
			
			//actualizar altura de nueva raiz
			nuevaRaiz.actualizarAltura();
			
			//retornamos nueva raiz
			return nuevaRaiz;
			
		}
		
		//rotacion doble con derecha
		public void rotacionDobleDerecha() 
		{    
			//1º rotacion simple con izquierdo en hijo derecho
			AVL nuevoHijoDerecho=this.getHijoDerecho().rotacionSimpleIzquierda();
			this.agregarHijoDerecho(nuevoHijoDerecho);
			
			//2º rotacion simple derecha
			return this.rotacionSimpleDerecha();
			
		}
		
		//rotacion doble con izquierda	
		public void rotacionDobleIzquierda() 
		{
			//1º rotacion simple con derecho en hijo izquierdo
			AVL nuevoHijoIzquierdo=this.getHijoIzquierdo().rotacionSimpleDerecha();
			this.agregarHijoIzquierdo(nuevoHijoIzquierdo);
			
			//2º rotacion simple izquierda
			return this.rotacionSimpleIzquierda();
		}
		
		private void actualizaAltura()
		{
			int alturaIzq=-1;
			int alturaDer=-1;
			
			if (this.getHijoIzquierdo() !=null) {
				alturaIzq=this.getHijoIzquierdo().altura;
			}
			if (this.getHijoDerecho!=null) {
				alturaDer=this.getHijoDerecho().altura;
			}
			
			if (alturaDer>alturaIzq) {
				this.altura=alturaDer+1;
			}
			else
			{
				this.altura=alturaIzq+1;
			}
		}
		
	}
}