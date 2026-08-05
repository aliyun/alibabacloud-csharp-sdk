// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveStreamWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the watermark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my watermark</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The height of the watermark image, in pixels. This value is relative to <c>RefHeight</c> and will be scaled proportionally with the actual video resolution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>The name of the watermark template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>livewatermark****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The anchor point for the watermark\&quot;s position. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>TopLeft</para>
        /// </description></item>
        /// <item><description><para>TopRight</para>
        /// </description></item>
        /// <item><description><para>BottomLeft</para>
        /// </description></item>
        /// <item><description><para>BottomRight</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TopRight</para>
        /// </summary>
        [NameInMap("OffsetCorner")]
        [Validation(Required=false)]
        public string OffsetCorner { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The URL of the watermark image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com">http://example.com</a></para>
        /// </summary>
        [NameInMap("PictureUrl")]
        [Validation(Required=false)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// <para>The reference height of the video background, in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("RefHeight")]
        [Validation(Required=false)]
        public int? RefHeight { get; set; }

        /// <summary>
        /// <para>The reference width of the video background, in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("RefWidth")]
        [Validation(Required=false)]
        public int? RefWidth { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the watermark template.</para>
        /// <remarks>
        /// <para>You can get the template ID from the response of the <a href="https://help.aliyun.com/document_detail/2848096.html">AddLiveStreamWatermark</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The opacity of the watermark. Value range: <c>0</c> (fully transparent) to <c>255</c> (fully opaque).</para>
        /// 
        /// <b>Example:</b>
        /// <para>255</para>
        /// </summary>
        [NameInMap("Transparency")]
        [Validation(Required=false)]
        public int? Transparency { get; set; }

        /// <summary>
        /// <para>The X-axis offset of the watermark, in pixels.</para>
        /// <remarks>
        /// <para>Relative to RefWidth. If OffsetCorner is TopLeft, XOffset is the horizontal distance between the top‑left corner of the watermark and the top‑left corner of the background video. Positive X points to the right.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50.0</para>
        /// </summary>
        [NameInMap("XOffset")]
        [Validation(Required=false)]
        public float? XOffset { get; set; }

        /// <summary>
        /// <para>The Y-axis offset of the watermark, in pixels.</para>
        /// <remarks>
        /// <para>Relative to RefHeight. If OffsetCorner is TopLeft, YOffset is the vertical distance between the top‑left corner of the watermark and the top‑left corner of the background video. Positive Y points downward.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100.0</para>
        /// </summary>
        [NameInMap("YOffset")]
        [Validation(Required=false)]
        public float? YOffset { get; set; }

    }

}
