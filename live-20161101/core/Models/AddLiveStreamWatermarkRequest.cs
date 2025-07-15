// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamWatermarkRequest : TeaModel {
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
        /// <para>The streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The height of the watermark. Unit: pixels. The height of the watermark is scaled in proportion to the height of the background video.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>The name of the watermark.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>livewatermark****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The location of the watermark. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TopLeft: the upper-left corner.</description></item>
        /// <item><description>TopRight: the upper-right corner.</description></item>
        /// <item><description>BottomLeft: the lower-left corner.</description></item>
        /// <item><description>BottomRight: the lower-right corner.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com">http://example.com</a></para>
        /// </summary>
        [NameInMap("PictureUrl")]
        [Validation(Required=false)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// <para>The height of the background video. Unit: pixels.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("RefHeight")]
        [Validation(Required=false)]
        public int? RefHeight { get; set; }

        /// <summary>
        /// <para>The width of the background video. Unit: pixels.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("RefWidth")]
        [Validation(Required=false)]
        public int? RefWidth { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The transparency of the watermark. A smaller value indicates a more transparent watermark. Valid values: 0 to 255.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255</para>
        /// </summary>
        [NameInMap("Transparency")]
        [Validation(Required=false)]
        public int? Transparency { get; set; }

        /// <summary>
        /// <para>The type of the watermark. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: image.</description></item>
        /// <item><description><b>1</b>: text. Only image watermarks are supported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The offset of the watermark along the x-axis. Unit: pixels.</para>
        /// <remarks>
        /// <para> In this case, the value of the RefWidth parameter is used as the reference. If the OffsetCorner parameter is set to TopLeft, the value of the XOffset parameter indicates the x-axis offset of the upper-left corner of the watermark relative to that of the background video. The directions from the coordinate axes to the center of the background video are positive. In other words, the x-axis is positive toward the right.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50.0</para>
        /// </summary>
        [NameInMap("XOffset")]
        [Validation(Required=false)]
        public float? XOffset { get; set; }

        /// <summary>
        /// <para>The offset of the watermark along the y-axis. Unit: pixels.</para>
        /// <remarks>
        /// <para> In this case, the value of the RefHeight parameter is used as the reference. If the OffsetCorner parameter is set to TopLeft, the value of the YOffset parameter indicates the y-axis offset of the upper-left corner of the watermark relative to that of the background video. The directions from the coordinate axes to the center of the background video are positive. In other words, the y-axis is positive downward.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.0</para>
        /// </summary>
        [NameInMap("YOffset")]
        [Validation(Required=false)]
        public float? YOffset { get; set; }

    }

}
