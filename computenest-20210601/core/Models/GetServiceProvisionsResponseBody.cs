// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceProvisionsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the services.
        /// </summary>
        [NameInMap("ServiceProvisions")]
        [Validation(Required=false)]
        public List<GetServiceProvisionsResponseBodyServiceProvisions> ServiceProvisions { get; set; }
        public class GetServiceProvisionsResponseBodyServiceProvisions : TeaModel {
            /// <summary>
            /// Indicates whether automatic activation for the service is defined in the template. Valid values:
            /// 
            /// *   true: Automatic activation for the service is defined in the template.
            /// *   false: Manual activation for the service is defined in the template.
            /// </summary>
            [NameInMap("AutoEnableService")]
            [Validation(Required=false)]
            public bool? AutoEnableService { get; set; }

            /// <summary>
            /// The URL that points to the activation page of the service.
            /// 
            /// > This parameter is returned if Status is set to Disabled.
            /// </summary>
            [NameInMap("EnableURL")]
            [Validation(Required=false)]
            public string EnableURL { get; set; }

            /// <summary>
            /// The information about the RAM roles of the service. If this parameter is empty, no RAM role is associated with the service.
            /// </summary>
            [NameInMap("RoleProvision")]
            [Validation(Required=false)]
            public GetServiceProvisionsResponseBodyServiceProvisionsRoleProvision RoleProvision { get; set; }
            public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvision : TeaModel {
                /// <summary>
                /// The authorization URL of the RAM role.
                /// 
                /// > This parameter is returned if Created is set to false.
                /// </summary>
                [NameInMap("AuthorizationURL")]
                [Validation(Required=false)]
                public string AuthorizationURL { get; set; }

                /// <summary>
                /// The RAM roles of the service.
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public List<GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRoles> Roles { get; set; }
                public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRoles : TeaModel {
                    /// <summary>
                    /// The information about the API operation that is used to create the RAM role.
                    /// </summary>
                    [NameInMap("ApiForCreation")]
                    [Validation(Required=false)]
                    public GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRolesApiForCreation ApiForCreation { get; set; }
                    public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRolesApiForCreation : TeaModel {
                        /// <summary>
                        /// The name of the API operation.
                        /// </summary>
                        [NameInMap("ApiName")]
                        [Validation(Required=false)]
                        public string ApiName { get; set; }

                        /// <summary>
                        /// The ID of the Alibaba Cloud service to which the API operation belongs.
                        /// </summary>
                        [NameInMap("ApiProductId")]
                        [Validation(Required=false)]
                        public string ApiProductId { get; set; }

                        /// <summary>
                        /// The type of the API operation. Valid values:
                        /// 
                        /// *   Open: public
                        /// *   Inner: private
                        /// </summary>
                        [NameInMap("ApiType")]
                        [Validation(Required=false)]
                        public string ApiType { get; set; }

                        /// <summary>
                        /// The ROS parameters of the cluster.
                        /// </summary>
                        [NameInMap("parameters")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Parameters { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether the RAM role is created. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public bool? Created { get; set; }

                    /// <summary>
                    /// The purpose for which the RAM role is used. Default value: Default. A value of Default indicates that the RAM role is the default role of the service.
                    /// </summary>
                    [NameInMap("Function")]
                    [Validation(Required=false)]
                    public string Function { get; set; }

                    /// <summary>
                    /// The name of the role.
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

            }

            /// <summary>
            /// The service name.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The activation status of the service. Valid values:
            /// 
            /// *   Enabled: The service is activated.
            /// *   Disabled: The service is not activated.
            /// *   Unknown: The activation status of the service is unknown.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The reason why the service is in the Disabled or Unknown state.
            /// 
            /// > This parameter is returned if Status is set to Disabled or Unknown.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

    }

}
