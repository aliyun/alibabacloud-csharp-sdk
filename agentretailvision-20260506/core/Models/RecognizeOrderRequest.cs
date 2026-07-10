// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class RecognizeOrderRequest : TeaModel {
        /// <summary>
        /// <para>Callback URL for this task. If not provided, the registered default address is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/callback">https://example.com/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>List of candidate items. It is recommended to pass platform_item_id.</para>
        /// </summary>
        [NameInMap("CandidateItems")]
        [Validation(Required=false)]
        public List<string> CandidateItems { get; set; }

        /// <summary>
        /// <para>Device ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEVICE_001</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Unique idempotent ID of the business party, unique within the same business party</para>
        /// 
        /// <b>Example:</b>
        /// <para>ORDER_001</para>
        /// </summary>
        [NameInMap("OrderUniqueId")]
        [Validation(Required=false)]
        public string OrderUniqueId { get; set; }

        /// <summary>
        /// <para>List of shopping video OSS addresses (currently only one is supported)</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://oss.example.com/video1.mp4%22%5D">https://oss.example.com/video1.mp4&quot;]</a></para>
        /// </summary>
        [NameInMap("VideoUrls")]
        [Validation(Required=false)]
        public List<string> VideoUrls { get; set; }

    }

}
