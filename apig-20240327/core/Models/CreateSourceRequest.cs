// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateSourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtgi6q***</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("k8sSourceConfig")]
        [Validation(Required=false)]
        public CreateSourceRequestK8sSourceConfig K8sSourceConfig { get; set; }
        public class CreateSourceRequestK8sSourceConfig : TeaModel {
            [NameInMap("authorizeSecurityGroupRules")]
            [Validation(Required=false)]
            public List<CreateSourceRequestK8sSourceConfigAuthorizeSecurityGroupRules> AuthorizeSecurityGroupRules { get; set; }
            public class CreateSourceRequestK8sSourceConfigAuthorizeSecurityGroupRules : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("portRanges")]
                [Validation(Required=false)]
                public List<string> PortRanges { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-bp14w4fa4j***</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c3fbe6caaaece4062b*****</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        [NameInMap("nacosSourceConfig")]
        [Validation(Required=false)]
        public CreateSourceRequestNacosSourceConfig NacosSourceConfig { get; set; }
        public class CreateSourceRequestNacosSourceConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mse-cn-0dw3w***</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MSE_NACOS</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
