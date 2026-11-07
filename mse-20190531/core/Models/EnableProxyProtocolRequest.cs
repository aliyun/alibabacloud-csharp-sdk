// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class EnableProxyProtocolRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned results. Valid values: zh (default): Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the feature of preserving the client source IP address by using the PROXY protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the feature of preserving the client source IP address.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables the feature of preserving the client source IP address.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableProxyProtocol")]
        [Validation(Required=false)]
        public bool? EnableProxyProtocol { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-c9bc5afd61014165bd58f621b491*****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

    }

}
