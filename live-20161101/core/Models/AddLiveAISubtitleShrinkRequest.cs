// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveAISubtitleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The background color of the subtitles, which is an RGBA value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0xFF0000</para>
        /// </summary>
        [NameInMap("BgColor")]
        [Validation(Required=false)]
        public string BgColor { get; set; }

        /// <summary>
        /// <para>The background size of the subtitles. Valid values: [0,1].</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.09</para>
        /// </summary>
        [NameInMap("BgWidthNormalized")]
        [Validation(Required=false)]
        public float? BgWidthNormalized { get; set; }

        /// <summary>
        /// <para>The font weight. Valid values: [0,1].</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.05</para>
        /// </summary>
        [NameInMap("BorderWidthNormalized")]
        [Validation(Required=false)]
        public float? BorderWidthNormalized { get; set; }

        /// <summary>
        /// <para>The subtitle template that you copy. Set the value to the name of the subtitle template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub01</para>
        /// </summary>
        [NameInMap("CopyFrom")]
        [Validation(Required=false)]
        public string CopyFrom { get; set; }

        /// <summary>
        /// <para>The custom description of the subtitle template. The description can be up to 128 characters in length and can contain letters, digits, and special characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live AI subtitle template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The target language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en-US: English </description></item>
        /// <item><description>zh-CN: Chinese </description></item>
        /// <item><description>es-ES: Spanish </description></item>
        /// <item><description>ru-RU: Russian</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("DstLanguage")]
        [Validation(Required=false)]
        public string DstLanguage { get; set; }

        /// <summary>
        /// <para>The font color, which is an RGBA value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0xFFFFFF</para>
        /// </summary>
        [NameInMap("FontColor")]
        [Validation(Required=false)]
        public string FontColor { get; set; }

        /// <summary>
        /// <para>The font. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KaiTi (default)</description></item>
        /// <item><description>AlibabaPuHuiTi-Regular</description></item>
        /// <item><description>AlibabaPuHuiTi-Bold</description></item>
        /// <item><description>AlibabaPuHuiTi-Light</description></item>
        /// <item><description>NotoSansHans-Regular</description></item>
        /// <item><description>NotoSansHans-Bold</description></item>
        /// <item><description>NotoSansHans-Light</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KaiTi</para>
        /// </summary>
        [NameInMap("FontName")]
        [Validation(Required=false)]
        public string FontName { get; set; }

        /// <summary>
        /// <para>The font size. Valid values: [0,1].</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.037</para>
        /// </summary>
        [NameInMap("FontSizeNormalized")]
        [Validation(Required=false)]
        public float? FontSizeNormalized { get; set; }

        /// <summary>
        /// <para>The preview height. Unit: pixels.
        /// The following specifications of preview width × preview height are supported: </para>
        /// <list type="bullet">
        /// <item><description>Landscape low definition 360p (640×360) </description></item>
        /// <item><description>Portrait low definition 360p (360×640)</description></item>
        /// <item><description>Landscape standard definition 480p (854×480)</description></item>
        /// <item><description>Portrait standard definition 480p (480×854)</description></item>
        /// <item><description>Landscape high definition 720p (1280×720)</description></item>
        /// <item><description>Portrait high definition 720p (720×1280)</description></item>
        /// <item><description>Landscape ultra-high definition 1080p (1920×1080)</description></item>
        /// <item><description>Portrait ultra-high definition 1080p (1080×1920)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public string Height { get; set; }

        /// <summary>
        /// <para>The number of displayed lines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxLines")]
        [Validation(Required=false)]
        public int? MaxLines { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The position of the subtitles. The value is a pair of coordinates for which the origin of the x and y axes is the lower-left corner of the screen.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PositionNormalized")]
        [Validation(Required=false)]
        public string PositionNormalizedShrink { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the source language. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowSourceLan")]
        [Validation(Required=false)]
        public bool? ShowSourceLan { get; set; }

        /// <summary>
        /// <para>The source language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en-US: English </description></item>
        /// <item><description>zh-CN: Chinese </description></item>
        /// <item><description>ru-RU: Russian</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("SrcLanguage")]
        [Validation(Required=false)]
        public string SrcLanguage { get; set; }

        /// <summary>
        /// <para>The name of the subtitle template. The name can contain only digits, letters, and hyphens (-). The name cannot start with a hyphen.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub01</para>
        /// </summary>
        [NameInMap("SubtitleName")]
        [Validation(Required=false)]
        public string SubtitleName { get; set; }

        /// <summary>
        /// <para>The preview width. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public string Width { get; set; }

        /// <summary>
        /// <para>The number of words displayed per line. Valid values: integers from 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("WordPerLine")]
        [Validation(Required=false)]
        public int? WordPerLine { get; set; }

    }

}
