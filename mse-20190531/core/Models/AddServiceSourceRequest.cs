// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddServiceSourceRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN (default): Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// <item><description>ja: Japanese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor Ingress classes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9ad2a0717032427e920754e25b49e3b5</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>Specifies whether to update the Ingress status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-c70622ff52fe49beb29bea9a6f52****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The data structure.</para>
        /// </summary>
        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<string> GroupList { get; set; }

        /// <summary>
        /// <para>The list of service groups.</para>
        /// </summary>
        [NameInMap("IngressOptionsRequest")]
        [Validation(Required=false)]
        public AddServiceSourceRequestIngressOptionsRequest IngressOptionsRequest { get; set; }
        public class AddServiceSourceRequestIngressOptionsRequest : TeaModel {
            /// <summary>
            /// <para>The group to which the service belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIngress")]
            [Validation(Required=false)]
            public bool? EnableIngress { get; set; }

            /// <summary>
            /// <para>The language of the response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh-CN: Chinese. This is the default value.</description></item>
            /// <item><description>en-US: English.</description></item>
            /// <item><description>ja: Japanese.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public bool? EnableStatus { get; set; }

            /// <summary>
            /// <para>An array of service root paths.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.test.xxx</para>
            /// </summary>
            [NameInMap("IngressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            /// <summary>
            /// <para>The root path of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("WatchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// <para>The namespace whose resources you want to monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>istio</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// </summary>
        [NameInMap("PathList")]
        [Validation(Required=false)]
        public List<string> PathList { get; set; }

        /// <summary>
        /// <para>The service source.</para>
        /// <list type="bullet">
        /// <item><description>K8s: ACK cluster</description></item>
        /// <item><description>NACOS: MSE Nacos instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>K8s,MSE</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The list of security groups to be authorized. You can specify security groups to allow backend services to access data sources that you create.</para>
        /// </summary>
        [NameInMap("ToAuthorizeSecurityGroups")]
        [Validation(Required=false)]
        public List<AddServiceSourceRequestToAuthorizeSecurityGroups> ToAuthorizeSecurityGroups { get; set; }
        public class AddServiceSourceRequestToAuthorizeSecurityGroups : TeaModel {
            /// <summary>
            /// <para>The description of the authorization record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule for xxx</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The authorized port range of the security group. You can select multiple port ranges. Separate each port range with a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080/8080,9000/10000</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1acepclex0vmi1****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

        }

        /// <summary>
        /// <para>The type of the service source.</para>
        /// <list type="bullet">
        /// <item><description>K8s: Container Service for Kubernetes (ACK) cluster</description></item>
        /// <item><description>NACOS: Nacos instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The Ingress configuration.</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
