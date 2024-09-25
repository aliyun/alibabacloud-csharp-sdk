// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewaySlbShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-9cdcf8e4f58144059e73ff4c5ef9****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The HTTP port number (virtual service group).</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HttpPort")]
        [Validation(Required=false)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// <para>The HTTPS port number (virtual service group).</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("HttpsPort")]
        [Validation(Required=false)]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// <para>The ID of the HTTPS virtual service group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>353</para>
        /// </summary>
        [NameInMap("HttpsVServerGroupId")]
        [Validation(Required=false)]
        public string HttpsVServerGroupId { get; set; }

        /// <summary>
        /// <para>The service weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ServiceWeight")]
        [Validation(Required=false)]
        public int? ServiceWeight { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp18t6jjskwxh6wy1****</para>
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <para>The type of the service source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUB_NET: Internet</description></item>
        /// <item><description>PRIVATE_NET: VPC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUB_NET</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the HTTP virtual service group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>353</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// <para>The SLB monitoring information.</para>
        /// </summary>
        [NameInMap("VServiceList")]
        [Validation(Required=false)]
        public string VServiceListShrink { get; set; }

    }

}
