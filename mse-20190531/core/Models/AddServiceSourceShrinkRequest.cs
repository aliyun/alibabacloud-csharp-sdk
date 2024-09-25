// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddServiceSourceShrinkRequest : TeaModel {
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
        public string GroupListShrink { get; set; }

        /// <summary>
        /// <para>The list of service groups.</para>
        /// </summary>
        [NameInMap("IngressOptionsRequest")]
        [Validation(Required=false)]
        public string IngressOptionsRequestShrink { get; set; }

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
        public string PathListShrink { get; set; }

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
        public string ToAuthorizeSecurityGroupsShrink { get; set; }

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
