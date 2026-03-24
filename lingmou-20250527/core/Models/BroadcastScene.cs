// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class BroadcastScene : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("clipInfo")]
        [Validation(Required=false)]
        public string ClipInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/cover.jpg">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/cover.jpg</a></para>
        /// </summary>
        [NameInMap("coverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-03-24T11:21:27.691732</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/result.mp4">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/result.mp4</a></para>
        /// </summary>
        [NameInMap("downloadURL")]
        [Validation(Required=false)]
        public string DownloadURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BS1WgG5zb-N1GI8nId3r6wo8g</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-03-24T11:21:27.691732</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/preview.mp4">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/preview.mp4</a></para>
        /// </summary>
        [NameInMap("previewURL")]
        [Validation(Required=false)]
        public string PreviewURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9:16</para>
        /// </summary>
        [NameInMap("ratio")]
        [Validation(Required=false)]
        public string Ratio { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("remainSeconds")]
        [Validation(Required=false)]
        public long? RemainSeconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/result.mp4">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/result.mp4</a></para>
        /// </summary>
        [NameInMap("shortVideoURL")]
        [Validation(Required=false)]
        public string ShortVideoURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/thumbnail.jpg">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/BS1CQEYXYQW4MQU2/thumbnail.jpg</a></para>
        /// </summary>
        [NameInMap("thumbnailURL")]
        [Validation(Required=false)]
        public string ThumbnailURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

    }

}
