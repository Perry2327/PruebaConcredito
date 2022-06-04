/// <reference types="Cypress" />


beforeEach(() => {
    
    cy.fixture('example.json').then (function(datos){
      this.datos_prueba=datos
      cy.visit(this.datos_prueba.Searchname)
    })
    
  })
  
  
  describe ('BusquedasGoogle', function (){
     
      it ('1-Validacion busqueda sencilla', function (){
        
          cy.get('.gLFyf').type(this.datos_prueba.Dato1)        
          cy.url().then(url => {
          cy.get('.CqAVzb > center > .gNO89b').click()
          cy.url().should('not.eq', url);
        });
      })
  
      it ('2-Validacion Busqueda me siento con suerte', function (){
  
       
        cy.get('.gLFyf').type(this.datos_prueba.Dato2)
        cy.get('.CqAVzb > center > .RNmpXc').click()
      })

      it ('3-Validacion doble busqueda', function (){
        cy.get('.gLFyf').type(this.datos_prueba.Dato1)
        cy.get('.CqAVzb > center > .gNO89b').click()
        cy.get('input.gLFyf').clear()        
        cy.get('input.gLFyf').type(this.datos_prueba.Dato2)
        cy.get('.zgAlFc > .z1asCe > svg').click()

      })



      it ('4-Validacion cambio de pagina', function (){

        cy.get('.gLFyf').type(this.datos_prueba.Dato1)
        cy.get('.CqAVzb > center > .gNO89b').click()
        cy.get(':nth-child(3) > .fl').click()
               
      })


      it ('5-Validacion busqueda imagen ', function (){
         
        cy.get('.gLFyf').type(this.datos_prueba.Dato1)
        cy.get('.CqAVzb > center > .gNO89b').click()
        cy.get('.MUFPAc > :nth-child(2) > a').click()
        cy.get("div[data-id='OBXKSVc_feXZhM'] img[alt='Naruto Uzumaki | Naruto Wiki | Fandom']").click()
        cy.get('[jsname="lZmugf"]').click()
      })
         
  })
  
  
    