﻿
# Price List Repository

This view contains details information about Price List Repository building block, including:
- dependencies
- modules
- related processes  

---



## Domain Perspective


### Dependencies

```mermaid
  flowchart TB
    subgraph 0["PriceLists"]
      1(Price List Repository)
      class 1 DomainPerspective
    end
    subgraph 2["Clients"]
      3([Client Id])
      class 3 DomainPerspective
    end
    subgraph 4["Products"]
      5([Product Amount])
      class 5 DomainPerspective
    end
    0-->|depends on|2
    0-->|depends on|4
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

### Related process steps

Price List Repository is not used directly in any process step.  

## Next steps


### Zoom-in


#### Domain perspective


##### Ddd value objects

[Client Id](../../Clients/Client Id.md)  
[Product Amount](../../Products/Product Amount.md)  

### Zoom-out


#### Domain perspective


##### Domain modules

[PriceLists](PriceLists.md)  

---

[P3 Model](https://github.com/P3-model/P3-model) documentation generated from source code using [.net tooling](https://github.com/P3-model/P3-model-dotnet)