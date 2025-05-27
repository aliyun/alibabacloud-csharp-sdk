// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceProvisionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C27145F-C9F4-545D-A355-DCDDAD63D548</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the services.</para>
        /// </summary>
        [NameInMap("ServiceProvisions")]
        [Validation(Required=false)]
        public List<GetServiceProvisionsResponseBodyServiceProvisions> ServiceProvisions { get; set; }
        public class GetServiceProvisionsResponseBodyServiceProvisions : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic activation for the service is defined in the template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Automatic activation for the service is defined in the template.</description></item>
            /// <item><description>false: Manual activation for the service is defined in the template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoEnableService")]
            [Validation(Required=false)]
            public bool? AutoEnableService { get; set; }

            [NameInMap("CommodityProvisions")]
            [Validation(Required=false)]
            public List<GetServiceProvisionsResponseBodyServiceProvisionsCommodityProvisions> CommodityProvisions { get; set; }
            public class GetServiceProvisionsResponseBodyServiceProvisionsCommodityProvisions : TeaModel {
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("EnableURL")]
                [Validation(Required=false)]
                public string EnableURL { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The URL that points to the activation page of the service.</para>
            /// <remarks>
            /// <para>This parameter is returned if Status is set to Disabled.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://common-buy.aliyun.com/?commodityCode=sls">https://common-buy.aliyun.com/?commodityCode=sls</a></para>
            /// </summary>
            [NameInMap("EnableURL")]
            [Validation(Required=false)]
            public string EnableURL { get; set; }

            /// <summary>
            /// <para>The information about the RAM roles of the service. If this parameter is empty, no RAM role is associated with the service.</para>
            /// </summary>
            [NameInMap("RoleProvision")]
            [Validation(Required=false)]
            public GetServiceProvisionsResponseBodyServiceProvisionsRoleProvision RoleProvision { get; set; }
            public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvision : TeaModel {
                /// <summary>
                /// <para>The authorization URL of the RAM role.</para>
                /// <remarks>
                /// <para>This parameter is returned if Created is set to false.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://ram.console.aliyun.com/role/authorization?request=%7B%22Services%22:%5B%7B%22Service%22:%22CS%22,%22Roles%22:%5B%7B%22RoleName%22:%22AliyunCSManagedVKRole%22,%22TemplateId%22:%22AliyunCSManagedVKRole%22%7D,%7B%22RoleName%22:%22AliyunCSDefaultRole%22,%22TemplateId%22:%22Default%22%7D%5D%7D%5D,%22ReturnUrl%22:%22https://cs.console.aliyun.com/%22%7D">https://ram.console.aliyun.com/role/authorization?request={&quot;Services&quot;:[{&quot;Service&quot;:&quot;CS&quot;,&quot;Roles&quot;:[{&quot;RoleName&quot;:&quot;AliyunCSManagedVKRole&quot;,&quot;TemplateId&quot;:&quot;AliyunCSManagedVKRole&quot;},{&quot;RoleName&quot;:&quot;AliyunCSDefaultRole&quot;,&quot;TemplateId&quot;:&quot;Default&quot;}]}],&quot;ReturnUrl&quot;:&quot;https://cs.console.aliyun.com/&quot;}</a></para>
                /// </summary>
                [NameInMap("AuthorizationURL")]
                [Validation(Required=false)]
                public string AuthorizationURL { get; set; }

                /// <summary>
                /// <para>The RAM roles of the service.</para>
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public List<GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRoles> Roles { get; set; }
                public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRoles : TeaModel {
                    /// <summary>
                    /// <para>The information about the API operation that is used to create the RAM role.</para>
                    /// </summary>
                    [NameInMap("ApiForCreation")]
                    [Validation(Required=false)]
                    public GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRolesApiForCreation ApiForCreation { get; set; }
                    public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRolesApiForCreation : TeaModel {
                        /// <summary>
                        /// <para>The name of the API operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CreateServiceLinkedRole</para>
                        /// </summary>
                        [NameInMap("ApiName")]
                        [Validation(Required=false)]
                        public string ApiName { get; set; }

                        /// <summary>
                        /// <para>The ID of the Alibaba Cloud service to which the API operation belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rds</para>
                        /// </summary>
                        [NameInMap("ApiProductId")]
                        [Validation(Required=false)]
                        public string ApiProductId { get; set; }

                        /// <summary>
                        /// <para>The type of the API operation. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Open: public</description></item>
                        /// <item><description>Inner: private</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Open</para>
                        /// </summary>
                        [NameInMap("ApiType")]
                        [Validation(Required=false)]
                        public string ApiType { get; set; }

                        /// <summary>
                        /// <para>The ROS parameters of the cluster.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{ &quot;ServiceLinkedRole&quot;: &quot;AliyunServiceRoleForRdsPgsqlOnEcs&quot;, &quot;RegionId&quot;: &quot;${RegionId}&quot; }</para>
                        /// </summary>
                        [NameInMap("parameters")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Parameters { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether the RAM role is created. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public bool? Created { get; set; }

                    /// <summary>
                    /// <para>The purpose for which the RAM role is used. Default value: Default. A value of Default indicates that the RAM role is the default role of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Default</para>
                    /// </summary>
                    [NameInMap("Function")]
                    [Validation(Required=false)]
                    public string Function { get; set; }

                    /// <summary>
                    /// <para>The name of the role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AliyunCSManagedVKRole</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

            }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The activation status of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: The service is activated.</description></item>
            /// <item><description>Disabled: The service is not activated.</description></item>
            /// <item><description>Unknown: The activation status of the service is unknown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the service is in the Disabled or Unknown state.</para>
            /// <remarks>
            /// <para>This parameter is returned if Status is set to Disabled or Unknown.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>No permission</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

    }

}
