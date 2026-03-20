// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class BroadcastVideo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CQEYXYQW4MQU2/alignment.json">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CQEYXYQW4MQU2/alignment.json</a></para>
        /// </summary>
        [NameInMap("alignmentFileURL")]
        [Validation(Required=false)]
        public string AlignmentFileURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CQEYXYQW4MQU2/result.srt">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CQEYXYQW4MQU2/result.srt</a></para>
        /// </summary>
        [NameInMap("captionURL")]
        [Validation(Required=false)]
        public string CaptionURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CQEYXYQW4MQU2/cover.jpg">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CQEYXYQW4MQU2/cover.jpg</a></para>
        /// </summary>
        [NameInMap("coverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-11-28T13:40:33</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M1k3So6n9IlrDV69sr3jDa3g</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-11-28T13:41:31</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CQEYXYQW4MQU2/result.mp4">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CQEYXYQW4MQU2/result.mp4</a></para>
        /// </summary>
        [NameInMap("videoURL")]
        [Validation(Required=false)]
        public string VideoURL { get; set; }

    }

}
