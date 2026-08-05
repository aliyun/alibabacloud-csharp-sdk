// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveAISubtitleRequest : TeaModel {
        /// <summary>
        /// <para>The background color of the subtitle. The value is in RGBA format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0xFF0000</para>
        /// </summary>
        [NameInMap("BgColor")]
        [Validation(Required=false)]
        public string BgColor { get; set; }

        /// <summary>
        /// <para>The background size of the subtitle. Valid values: [0, 1].</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.09</para>
        /// </summary>
        [NameInMap("BgWidthNormalized")]
        [Validation(Required=false)]
        public float? BgWidthNormalized { get; set; }

        /// <summary>
        /// <para>The font weight. Valid values: [0, 1].</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.05</para>
        /// </summary>
        [NameInMap("BorderWidthNormalized")]
        [Validation(Required=false)]
        public float? BorderWidthNormalized { get; set; }

        /// <summary>
        /// <para>The custom description of the subtitle. The description can contain Chinese characters, letters, digits, and special characters, and cannot exceed 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live AI subtitle template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The target language for translation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en-US: English</description></item>
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>es-ES: Spanish</description></item>
        /// <item><description>ru-RU: Russian.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("DstLanguage")]
        [Validation(Required=false)]
        public string DstLanguage { get; set; }

        /// <summary>
        /// <para>The font color. The value is in RGBA format.</para>
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
        /// <item><description>KaiTi: KaiTi (default)</description></item>
        /// <item><description>AlibabaPuHuiTi-Regular: Alibaba PuHuiTi Regular</description></item>
        /// <item><description>AlibabaPuHuiTi-Bold: Alibaba PuHuiTi Bold</description></item>
        /// <item><description>AlibabaPuHuiTi-Light: Alibaba PuHuiTi Light</description></item>
        /// <item><description>NotoSansHans-Regular: Noto Sans Hans Regular</description></item>
        /// <item><description>NotoSansHans-Bold: Noto Sans Hans Bold</description></item>
        /// <item><description>NotoSansHans-Light: Noto Sans Hans Light.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KaiTi</para>
        /// </summary>
        [NameInMap("FontName")]
        [Validation(Required=false)]
        public string FontName { get; set; }

        /// <summary>
        /// <para>The font size. Valid values: [0, 1].</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.037</para>
        /// </summary>
        [NameInMap("FontSizeNormalized")]
        [Validation(Required=false)]
        public float? FontSizeNormalized { get; set; }

        /// <summary>
        /// <para>The height of the preview screen. Unit: px.</para>
        /// <para>The width × height of the preview screen supports only the following specifications:</para>
        /// <list type="bullet">
        /// <item><description>Landscape low definition 360P: 640×360</description></item>
        /// <item><description>Portrait low definition 360P: 360×640</description></item>
        /// <item><description>Landscape standard definition 480P: 854×480</description></item>
        /// <item><description>Portrait standard definition 480P: 480×854</description></item>
        /// <item><description>Landscape high definition 720P: 1280×720</description></item>
        /// <item><description>Portrait high definition 720P: 720×1280</description></item>
        /// <item><description>Landscape ultra-high definition 1080P: 1920×1080</description></item>
        /// <item><description>Portrait ultra-high definition 1080P: 1080×1920.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public string Height { get; set; }

        /// <summary>
        /// <para>The number of lines to display.</para>
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
        /// <para>The position of the subtitle, specified as x and y coordinates with the bottom-left corner of the screen as the origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0.32,0.27]</para>
        /// </summary>
        [NameInMap("PositionNormalized")]
        [Validation(Required=false)]
        public List<float?> PositionNormalized { get; set; }

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
        /// <item><description>en-US: English</description></item>
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>ru-RU: Russian.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("SrcLanguage")]
        [Validation(Required=false)]
        public string SrcLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the subtitle template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>597991f3-6ef9-4100-9238-82951de1****</para>
        /// </summary>
        [NameInMap("SubtitleId")]
        [Validation(Required=false)]
        public string SubtitleId { get; set; }

        /// <summary>
        /// <para>The name of the subtitle template. The name can contain only digits, letters, and hyphens (-). The name cannot start with a hyphen.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live AI subtitle template</para>
        /// </summary>
        [NameInMap("SubtitleName")]
        [Validation(Required=false)]
        public string SubtitleName { get; set; }

        /// <summary>
        /// <para>The width of the preview screen. Unit: px.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public string Width { get; set; }

        /// <summary>
        /// <para>The number of characters per line. Valid values: integers in the range of [1, 500].</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("WordPerLine")]
        [Validation(Required=false)]
        public int? WordPerLine { get; set; }

    }

}
