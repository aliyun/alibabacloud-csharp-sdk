// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class StopDistributionChannelCommand : TeaModel {
        /// <summary>
        /// <para>The set of channel IDs.</para>
        /// </summary>
        [NameInMap("channelCodes")]
        [Validation(Required=false)]
        public List<string> ChannelCodes { get; set; }

        /// <summary>
        /// <para>The store ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1100001</para>
        /// </summary>
        [NameInMap("lmShopId")]
        [Validation(Required=false)]
        public string LmShopId { get; set; }

        /// <summary>
        /// <para>The commodity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>660******080</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request time. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("requestTime")]
        [Validation(Required=false)]
        public string RequestTime { get; set; }

        /// <summary>
        /// <para>The requesting user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12000000001</para>
        /// </summary>
        [NameInMap("requestUser")]
        [Validation(Required=false)]
        public string RequestUser { get; set; }

    }

}
