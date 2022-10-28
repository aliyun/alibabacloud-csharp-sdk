// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetServiceProvisionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceProvisions")]
        [Validation(Required=false)]
        public List<GetServiceProvisionsResponseBodyServiceProvisions> ServiceProvisions { get; set; }
        public class GetServiceProvisionsResponseBodyServiceProvisions : TeaModel {
            [NameInMap("AutoEnableService")]
            [Validation(Required=false)]
            public bool? AutoEnableService { get; set; }

            [NameInMap("DependentServiceNames")]
            [Validation(Required=false)]
            public List<string> DependentServiceNames { get; set; }

            [NameInMap("EnableURL")]
            [Validation(Required=false)]
            public string EnableURL { get; set; }

            [NameInMap("RoleProvision")]
            [Validation(Required=false)]
            public GetServiceProvisionsResponseBodyServiceProvisionsRoleProvision RoleProvision { get; set; }
            public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvision : TeaModel {
                [NameInMap("AuthorizationURL")]
                [Validation(Required=false)]
                public string AuthorizationURL { get; set; }

                [NameInMap("Roles")]
                [Validation(Required=false)]
                public List<GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRoles> Roles { get; set; }
                public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRoles : TeaModel {
                    [NameInMap("ApiForCreation")]
                    [Validation(Required=false)]
                    public GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRolesApiForCreation ApiForCreation { get; set; }
                    public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRolesApiForCreation : TeaModel {
                        [NameInMap("ApiName")]
                        [Validation(Required=false)]
                        public string ApiName { get; set; }

                        [NameInMap("ApiProductId")]
                        [Validation(Required=false)]
                        public string ApiProductId { get; set; }

                        [NameInMap("ApiType")]
                        [Validation(Required=false)]
                        public string ApiType { get; set; }

                        [NameInMap("Parameters")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Parameters { get; set; }

                    }

                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public bool? Created { get; set; }

                    [NameInMap("Function")]
                    [Validation(Required=false)]
                    public string Function { get; set; }

                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

            }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

    }

}
