// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class RecognizeOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/callback">https://example.com/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("CandidateItems")]
        [Validation(Required=false)]
        public string CandidateItemsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DEVICE_001</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ORDER_001</para>
        /// </summary>
        [NameInMap("OrderUniqueId")]
        [Validation(Required=false)]
        public string OrderUniqueId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://oss.example.com/video1.mp4%22%5D">https://oss.example.com/video1.mp4&quot;]</a></para>
        /// </summary>
        [NameInMap("VideoUrls")]
        [Validation(Required=false)]
        public string VideoUrlsShrink { get; set; }

    }

}
