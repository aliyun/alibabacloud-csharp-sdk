// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateSourceRequest : TeaModel {
        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtgi6q***</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The Container Service source configuration.</para>
        /// </summary>
        [NameInMap("k8sSourceConfig")]
        [Validation(Required=false)]
        public CreateSourceRequestK8sSourceConfig K8sSourceConfig { get; set; }
        public class CreateSourceRequestK8sSourceConfig : TeaModel {
            /// <summary>
            /// <para>The list of gateway security group authorization rule configurations.</para>
            /// </summary>
            [NameInMap("authorizeSecurityGroupRules")]
            [Validation(Required=false)]
            public List<CreateSourceRequestK8sSourceConfigAuthorizeSecurityGroupRules> AuthorizeSecurityGroupRules { get; set; }
            public class CreateSourceRequestK8sSourceConfigAuthorizeSecurityGroupRules : TeaModel {
                /// <summary>
                /// <para>The rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>预发网关访问安全组</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The list of port ranges.</para>
                /// </summary>
                [NameInMap("portRanges")]
                [Validation(Required=false)]
                public List<string> PortRanges { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp14w4fa4j***</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

            /// <summary>
            /// <para>The Container Service cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c3fbe6caaaece4062b*****</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        /// <summary>
        /// <para>The MSE Nacos source configuration.</para>
        /// </summary>
        [NameInMap("nacosSourceConfig")]
        [Validation(Required=false)]
        public CreateSourceRequestNacosSourceConfig NacosSourceConfig { get; set; }
        public class CreateSourceRequestNacosSourceConfig : TeaModel {
            /// <summary>
            /// <para>The Nacos instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-0dw3w***</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE_NACOS: MSE Nacos.</description></item>
        /// <item><description>K8S: Container Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_NACOS</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
