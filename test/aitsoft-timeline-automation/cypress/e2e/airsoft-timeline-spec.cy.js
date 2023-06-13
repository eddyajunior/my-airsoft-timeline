describe('Open Swagger', () => {
  it('passes', () => {
    cy.visit('https://localhost:7033/swagger/index.html')
  })
})