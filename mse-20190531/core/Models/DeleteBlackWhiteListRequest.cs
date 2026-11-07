// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteBlackWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values: zh (default): Chinese, en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>430</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-9cdcf8e4f58144059e73ff4c5ef9****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the blacklists and whitelists entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
