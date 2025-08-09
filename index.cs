.botao {
  background-color: #f25c05; /* laranja vibrante */
  color: white;
  font-weight: bold;
  border: none;
  border-radius: 8px;
  padding: 15px 25px;
  margin: 10px 0;
  cursor: pointer;
  transition: box-shadow 0.3s ease, transform 0.3s ease;
  box-shadow: none;
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 10px; /* espaço entre emoji e texto */
  font-size: 1rem;
}

.botao:hover {
  box-shadow: 0 4px 12px rgba(242, 92, 5, 0.7); /* sombra alaranjada */
  transform: translateY(-3px); /* leve elevação */
}
