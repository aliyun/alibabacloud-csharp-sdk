// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddServiceSourceRequest : TeaModel {
        /// <summary>
        /// <para>The supported languages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese. This is the default value.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// <item><description>ja: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The access address. This parameter is required.</para>
        /// <list type="bullet">
        /// <item><description>Container Service: the ID of the Container Service cluster.</description></item>
        /// <item><description>MSE Nacos: the internal endpoint of the instance.</description></item>
        /// <item><description>MSE ZooKeeper: the internal endpoint of the instance.</description></item>
        /// <item><description>SAE registry: the namespace TID.</description></item>
        /// <item><description>EDAS registry: the microservice namespace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse-********-nacos-ans.mse.aliyuncs.com:8848</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-c70622ff52fe49beb29bea9a6f52****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The list of service groups.</para>
        /// </summary>
        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<string> GroupList { get; set; }

        /// <summary>
        /// <para>The Ingress configurations. This parameter is used when the service source type is K8s.</para>
        /// </summary>
        [NameInMap("IngressOptionsRequest")]
        [Validation(Required=false)]
        public AddServiceSourceRequestIngressOptionsRequest IngressOptionsRequest { get; set; }
        public class AddServiceSourceRequestIngressOptionsRequest : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable Ingress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIngress")]
            [Validation(Required=false)]
            public bool? EnableIngress { get; set; }

            /// <summary>
            /// <para>Specifies whether to update the Ingress status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public bool? EnableStatus { get; set; }

            /// <summary>
            /// <para>The Ingress class to listen on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.test.xxx</para>
            /// </summary>
            [NameInMap("IngressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            /// <summary>
            /// <para>The target namespace to watch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("WatchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// <para>The name.</para>
        /// <remarks>
        /// <para>Descriptions for different source types.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>When the type is K8s, the input parameter is the name.</description></item>
        /// <item><description>When the type is NACOS, the input parameter is the instance ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nacos</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The array of service root paths.</para>
        /// </summary>
        [NameInMap("PathList")]
        [Validation(Required=false)]
        public List<string> PathList { get; set; }

        /// <summary>
        /// <para>The service source type:</para>
        /// <list type="bullet">
        /// <item><description>Container Service: K8S</description></item>
        /// <item><description>MSE Nacos: MSE</description></item>
        /// <item><description>MSE ZooKeeper: MSE_ZK</description></item>
        /// <item><description>SAE registry: SAE</description></item>
        /// <item><description>EDAS registry: EDAS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MSE</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The list of security groups to be authorized. This parameter is used to remove security group restrictions for backend services when creating a source.</para>
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
            /// <para>The authorized port range of the security group. You can specify multiple port ranges separated by commas (,).</para>
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
        /// <para>The service registration type. Specify the corresponding value based on the source type:</para>
        /// <list type="bullet">
        /// <item><description>Container Service: K8S</description></item>
        /// <item><description>MSE Nacos: NACOS</description></item>
        /// <item><description>MSE ZooKeeper: ZOOKEEPER</description></item>
        /// <item><description>SAE registry: NACOS</description></item>
        /// <item><description>EDAS registry: NACOS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NACOS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
