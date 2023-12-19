﻿
# Client Status

***Ddd Value Object***  

This view contains details information about Client Status building block, including:
- dependencies
- modules
- related processes  

---



## Domain Perspective


### Dependencies

```mermaid
  flowchart TB
    subgraph 0["Sales / Orders / Price Changes"]
      1([Price Changes Policies])
      class 1 DomainPerspective
    end
    subgraph 2["Sales / Clients"]
      3(Client Status)
      class 3 DomainPerspective
    end
    0-->|depends on|2
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

### Related process steps

No related processes were found.  

## Technology Perspective


### Source code

[ClientStatus.cs](../../../../../../../Sources/Sales/Sales.DeepModel/Clients/ClientStatus.cs)  

## Next steps


### Zoom-out


#### Domain perspective


##### Domain Modules

[Sales | Clients](Clients.md)  

---

[P3 Model](https://github.com/P3-model/P3-model) documentation generated from source code using [.net tooling](https://github.com/P3-model/P3-model-dotnet)