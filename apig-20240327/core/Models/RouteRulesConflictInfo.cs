// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RouteRulesConflictInfo : TeaModel {
        [NameInMap("conflicts")]
        [Validation(Required=false)]
        public List<RouteRulesConflictInfoConflicts> Conflicts { get; set; }
        public class RouteRulesConflictInfoConflicts : TeaModel {
            [NameInMap("details")]
            [Validation(Required=false)]
            public List<RouteRulesConflictInfoConflictsDetails> Details { get; set; }
            public class RouteRulesConflictInfoConflictsDetails : TeaModel {
                [NameInMap("conflictingMatch")]
                [Validation(Required=false)]
                public RouteRulesConflictInfoConflictsDetailsConflictingMatch ConflictingMatch { get; set; }
                public class RouteRulesConflictInfoConflictsDetailsConflictingMatch : TeaModel {
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpRouteMatch Match { get; set; }

                    [NameInMap("operationInfo")]
                    [Validation(Required=false)]
                    public RouteRulesConflictInfoConflictsDetailsConflictingMatchOperationInfo OperationInfo { get; set; }
                    public class RouteRulesConflictInfoConflictsDetailsConflictingMatchOperationInfo : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("operationId")]
                        [Validation(Required=false)]
                        public string OperationId { get; set; }

                    }

                }

                [NameInMap("detectedMatch")]
                [Validation(Required=false)]
                public RouteRulesConflictInfoConflictsDetailsDetectedMatch DetectedMatch { get; set; }
                public class RouteRulesConflictInfoConflictsDetailsDetectedMatch : TeaModel {
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpRouteMatch Match { get; set; }

                    [NameInMap("operationInfo")]
                    [Validation(Required=false)]
                    public RouteRulesConflictInfoConflictsDetailsDetectedMatchOperationInfo OperationInfo { get; set; }
                    public class RouteRulesConflictInfoConflictsDetailsDetectedMatchOperationInfo : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("operationId")]
                        [Validation(Required=false)]
                        public string OperationId { get; set; }

                    }

                }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            [NameInMap("environmentInfo")]
            [Validation(Required=false)]
            public RouteRulesConflictInfoConflictsEnvironmentInfo EnvironmentInfo { get; set; }
            public class RouteRulesConflictInfoConflictsEnvironmentInfo : TeaModel {
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("resourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("domainInfo")]
        [Validation(Required=false)]
        public RouteRulesConflictInfoDomainInfo DomainInfo { get; set; }
        public class RouteRulesConflictInfoDomainInfo : TeaModel {
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
