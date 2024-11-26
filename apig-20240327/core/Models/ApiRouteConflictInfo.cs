// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ApiRouteConflictInfo : TeaModel {
        [NameInMap("conflicts")]
        [Validation(Required=false)]
        public List<ApiRouteConflictInfoConflicts> Conflicts { get; set; }
        public class ApiRouteConflictInfoConflicts : TeaModel {
            [NameInMap("details")]
            [Validation(Required=false)]
            public List<ApiRouteConflictInfoConflictsDetails> Details { get; set; }
            public class ApiRouteConflictInfoConflictsDetails : TeaModel {
                [NameInMap("conflictingMatch")]
                [Validation(Required=false)]
                public ApiRouteConflictInfoConflictsDetailsConflictingMatch ConflictingMatch { get; set; }
                public class ApiRouteConflictInfoConflictsDetailsConflictingMatch : TeaModel {
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpRouteMatch Match { get; set; }

                    [NameInMap("operationInfo")]
                    [Validation(Required=false)]
                    public ApiRouteConflictInfoConflictsDetailsConflictingMatchOperationInfo OperationInfo { get; set; }
                    public class ApiRouteConflictInfoConflictsDetailsConflictingMatchOperationInfo : TeaModel {
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
                public ApiRouteConflictInfoConflictsDetailsDetectedMatch DetectedMatch { get; set; }
                public class ApiRouteConflictInfoConflictsDetailsDetectedMatch : TeaModel {
                    [NameInMap("match")]
                    [Validation(Required=false)]
                    public HttpRouteMatch Match { get; set; }

                    [NameInMap("operationInfo")]
                    [Validation(Required=false)]
                    public ApiRouteConflictInfoConflictsDetailsDetectedMatchOperationInfo OperationInfo { get; set; }
                    public class ApiRouteConflictInfoConflictsDetailsDetectedMatchOperationInfo : TeaModel {
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
            public ApiRouteConflictInfoConflictsEnvironmentInfo EnvironmentInfo { get; set; }
            public class ApiRouteConflictInfoConflictsEnvironmentInfo : TeaModel {
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

            [NameInMap("routeInfo")]
            [Validation(Required=false)]
            public ApiRouteConflictInfoConflictsRouteInfo RouteInfo { get; set; }
            public class ApiRouteConflictInfoConflictsRouteInfo : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("routeId")]
                [Validation(Required=false)]
                public string RouteId { get; set; }

            }

        }

        [NameInMap("domainInfo")]
        [Validation(Required=false)]
        public ApiRouteConflictInfoDomainInfo DomainInfo { get; set; }
        public class ApiRouteConflictInfoDomainInfo : TeaModel {
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
