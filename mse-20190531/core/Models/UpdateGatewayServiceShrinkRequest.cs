// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayServiceShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>501</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-c9bc5afd61014165bd58f621b491*****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>322</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ServicePort")]
        [Validation(Required=false)]
        public string ServicePort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ServiceProtocol")]
        [Validation(Required=false)]
        public string ServiceProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;mode&quot;: &quot;MUTUAL&quot;,
        ///       &quot;certId&quot;: &quot;1*****-cn-hangzhou&quot;,
        ///       &quot;caCertContent&quot;: &quot;123&quot;,
        ///       &quot;sni&quot;: &quot;ceshi&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TlsSetting")]
        [Validation(Required=false)]
        public string TlsSetting { get; set; }

    }

}
