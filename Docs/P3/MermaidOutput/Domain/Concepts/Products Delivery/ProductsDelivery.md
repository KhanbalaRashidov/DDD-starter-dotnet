﻿
# Products Delivery

***Domain Module***  

This view contains details information about Products Delivery domain module, including:
- other related modules
- related processes
- related building blocks
- related deployable units
- engaged people: actors, development teams, business stakeholders  

---



## Domain Perspective


### Related modules

No related modules were found.  

### Related processes

No related processes were found.  

### Direct building blocks

No direct building blocks were found.  

## Technology Perspective


### Related deployable units

```mermaid
  flowchart TB
    0(Products Delivery)
    class 0 DomainPerspective
    1([ecommerce-monolith])
    class 1 TechnologyPerspective
    0-->|is deployed in|1
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

## People Perspective


### Engaged people

```mermaid
  flowchart TB
    0(Products Delivery)
    class 0 DomainPerspective
    1([Inventory team])
    class 1 PeoplePerspective
    1-->|develops & maintains|0
    2([Inventory department])
    class 2 PeoplePerspective
    2-->|owns|0
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

## Next steps


### Zoom-in


#### Technology perspective


##### Deployable Units

[ecommerce-monolith](../../../Technology/DeployableUnits/EcommerceMonolith.md)  

#### People perspective


##### Business Organizational Units

[Inventory department](../../../People/BusinessOrganizationalUnits/InventoryDepartment.md)  

##### Development Teams

[Inventory team](../../../People/DevelopmentTeams/InventoryTeam.md)  

### Zoom-out


#### Domain perspective

[Domain Modules](../DomainModules.md)  

---

[P3 Model](https://github.com/P3-model/P3-model) documentation generated from source code using [.net tooling](https://github.com/P3-model/P3-model-dotnet)