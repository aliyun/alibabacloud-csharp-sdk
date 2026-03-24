// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class BroadcastSceneTemplate : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CSNSAsOIDZQU2/cover.jpg">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CSNSAsOIDZQU2/cover.jpg</a></para>
        /// </summary>
        [NameInMap("coverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-06T07:00:02Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BS1tneDiuOOjJmI2qOHGw1urA</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-06T07:00:02Z</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CSNSAsOIDZQU2/result.mp4">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CSNSAsOIDZQU2/result.mp4</a></para>
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
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CSNSAsOIDZQU2/result_preview.mp4">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CSNSAsOIDZQU2/result_preview.mp4</a></para>
        /// </summary>
        [NameInMap("shortVideoURL")]
        [Validation(Required=false)]
        public string ShortVideoURL { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CSNSAsOIDZQU2/thumbnail.jpg">https://online-avatar-property.oss-cn-beijing.aliyuncs.com/aigc_material/OUTPUT_BROADCAST_SHORT_VIDEO/Mt.CSNSAsOIDZQU2/thumbnail.jpg</a></para>
        /// </summary>
        [NameInMap("thumbnailURL")]
        [Validation(Required=false)]
        public string ThumbnailURL { get; set; }

    }

}
