// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetServiceProvisionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A9938C04-26AD-5EFA-B394-EA7866842DFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the Alibaba Cloud services.</para>
        /// </summary>
        [NameInMap("ServiceProvisions")]
        [Validation(Required=false)]
        public List<GetServiceProvisionsResponseBodyServiceProvisions> ServiceProvisions { get; set; }
        public class GetServiceProvisionsResponseBodyServiceProvisions : TeaModel {
            /// <summary>
            /// <para>Indicates whether the service is automatically activated when the template is used to create a stack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The service is automatically activated.</para>
            /// </description></item>
            /// <item><description><para>false: The service is not automatically activated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoEnableService")]
            [Validation(Required=false)]
            public bool? AutoEnableService { get; set; }

            /// <summary>
            /// <para>The details of the commodity. Some services, such as Container Compute Service (ACS), require you to activate multiple commodities.</para>
            /// </summary>
            [NameInMap("CommodityProvisions")]
            [Validation(Required=false)]
            public List<GetServiceProvisionsResponseBodyServiceProvisionsCommodityProvisions> CommodityProvisions { get; set; }
            public class GetServiceProvisionsResponseBodyServiceProvisionsCommodityProvisions : TeaModel {
                /// <summary>
                /// <para>The commodity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_postpaid_public_cn</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The URL for activating the commodity.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://common-buy.aliyun.com/?commodityCode=acs_postpaid_public_cn">https://common-buy.aliyun.com/?commodityCode=acs_postpaid_public_cn</a></para>
                /// </summary>
                [NameInMap("EnableURL")]
                [Validation(Required=false)]
                public string EnableURL { get; set; }

                /// <summary>
                /// <para>The activation status of the Alibaba Cloud service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enabled: The service is activated.</para>
                /// </description></item>
                /// <item><description><para>Disabled: The service is not activated.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The services on which the service that you want to query depends.</para>
            /// </summary>
            [NameInMap("DependentServiceNames")]
            [Validation(Required=false)]
            public List<string> DependentServiceNames { get; set; }

            /// <summary>
            /// <para>The URL that you can use to activate the Alibaba Cloud service.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the value of Status is Disabled.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://common-buy.aliyun.com/?commodityCode=nas">https://common-buy.aliyun.com/?commodityCode=nas</a></para>
            /// </summary>
            [NameInMap("EnableURL")]
            [Validation(Required=false)]
            public string EnableURL { get; set; }

            /// <summary>
            /// <para>The information about the service-linked roles of the Alibaba Cloud service. If this parameter is empty, no service-linked role is associated with the service.</para>
            /// </summary>
            [NameInMap("RoleProvision")]
            [Validation(Required=false)]
            public GetServiceProvisionsResponseBodyServiceProvisionsRoleProvision RoleProvision { get; set; }
            public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvision : TeaModel {
                /// <summary>
                /// <para>The URL that you can use to grant permissions to the service-linked role.</para>
                /// <remarks>
                /// <para>This parameter is returned only when the value of Created is false.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://ehpc.console.aliyun.com/">https://ehpc.console.aliyun.com/</a></para>
                /// </summary>
                [NameInMap("AuthorizationURL")]
                [Validation(Required=false)]
                public string AuthorizationURL { get; set; }

                /// <summary>
                /// <para>The service-linked roles.</para>
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public List<GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRoles> Roles { get; set; }
                public class GetServiceProvisionsResponseBodyServiceProvisionsRoleProvisionRoles : TeaModel {
                    /// <summary>
                    /// <para>The information about the API operation that is used to create the role.</para>
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
                        /// <item><description><para>Open: an Alibaba Cloud API operation.</para>
                        /// </description></item>
                        /// <item><description><para>Inner: an internal API operation.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Open</para>
                        /// </summary>
                        [NameInMap("ApiType")]
                        [Validation(Required=false)]
                        public string ApiType { get; set; }

                        /// <summary>
                        /// <para>The parameters of the API operation. The value of a parameter is a dynamic value. The following dynamic value is supported: ${RegionId}, which indicates the region ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{   &quot;ServiceLinkedRole&quot;: &quot;AliyunServiceRoleForRdsPgsqlOnEcs&quot;,   &quot;RegionId&quot;: &quot;${RegionId}&quot; }</para>
                        /// </summary>
                        [NameInMap("Parameters")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Parameters { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether the service-linked role is created. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: The service-linked role is created.</para>
                    /// </description></item>
                    /// <item><description><para>false: The service-linked role is not created.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public bool? Created { get; set; }

                    /// <summary>
                    /// <para>The purpose of the role. Default value: Default. This value indicates that the role is the default role of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Default</para>
                    /// </summary>
                    [NameInMap("Function")]
                    [Validation(Required=false)]
                    public string Function { get; set; }

                    /// <summary>
                    /// <para>The name of the service-linked role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AliyunServiceRoleForEHPC</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EHPC</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The activation status of the Alibaba Cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Enabled: The service is activated.</para>
            /// </description></item>
            /// <item><description><para>Disabled: The service is not activated.</para>
            /// </description></item>
            /// <item><description><para>Unknown: The activation status is unknown.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the Alibaba Cloud service is not activated or the activation status is unknown.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the value of Status is Disabled or Unknown.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>No permission.</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

    }

}
