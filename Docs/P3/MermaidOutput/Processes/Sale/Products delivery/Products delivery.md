﻿
# Products delivery

This view contains details information about Products delivery business process, including:
- other related processes
- process steps
- related domain modules
- related deployable units
- engaged people: actors, development teams, business stakeholders  

---



## Domain Perspective


### Related processes and steps

```mermaid
  flowchart TB
    0(Products delivery)
    class 0 DomainPerspective
    1([Sale])
    class 1 DomainPerspective
    0---1
    1-->|is part of|0
    1---0
    2([RequestDelivery])
    class 2 DomainPerspective
    0-->|contains|2
    linkStyle 0,2 stroke:none
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

### Related modules

```mermaid
  flowchart TB
    0(Products delivery)
    class 0 DomainPerspective
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

## Technology Perspective


### Related deployable units

```mermaid
  flowchart TB
    0(Products delivery)
    class 0 DomainPerspective
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

## People Perspective


### Engaged people

```mermaid
  flowchart LR
    subgraph 0["Actors"]
      direction TB
    end
    1(Products delivery)
    class 1 DomainPerspective
    0-->|uses|1
    subgraph 2["Teams"]
      direction TB
    end
    1---2
    2-->|develops & maintains|1
    2---1
    subgraph 3["Business"]
      direction TB
    end
    1---3
    3-->|owns|1
    3---1
    linkStyle 1,3,4,6 stroke:none
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

## Next steps


### Zoom-in


#### Domain perspective


##### Process steps

[RequestDelivery](../../../ProcessSteps/Sale/Products delivery/RequestDelivery.md)  

### Zoom-out


#### Domain perspective


##### Cross elements

[Business processes](../../../Business_Processes.md)  

---

[P3 Model](https://github.com/P3-model/P3-model) documentation generated from source code using [.net tooling](https://github.com/P3-model/P3-model-dotnet)