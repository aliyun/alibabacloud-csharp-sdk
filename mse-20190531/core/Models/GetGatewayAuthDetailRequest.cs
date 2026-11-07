// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayAuthDetailRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese. This is the default value.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The gateway ID. Specify either this parameter or GatewayUniqueId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2274</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway. Specify either this parameter or GatewayId. If both are specified, GatewayUniqueId takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-6f0dbd108a0249d2b675b3ef50b*****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The authentication ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1100</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
