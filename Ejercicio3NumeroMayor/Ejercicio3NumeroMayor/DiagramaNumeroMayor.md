```mermaid
flowchart TD
    A([INICIO]) --> B[/Ingresar primer número a/]
    B --> C[/Ingresar segundo número b/]
    C --> D{"¿a > b?"}
    D -- Sí --> E[/Mostrar a como mayor/]
    D -- No --> F{"¿b > a?"}
    F -- Sí --> G[/Mostrar b como mayor/]
    F -- No --> H[/Mostrar que son iguales/]
    E --> I([FIN])
    G --> I
    H --> I
```