// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAISubtitleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0df228-4a64- af62-20e91b96****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the subtitle templates.</para>
        /// </summary>
        [NameInMap("SubtitleConfigs")]
        [Validation(Required=false)]
        public DescribeLiveAISubtitleResponseBodySubtitleConfigs SubtitleConfigs { get; set; }
        public class DescribeLiveAISubtitleResponseBodySubtitleConfigs : TeaModel {
            [NameInMap("SubtitleConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfig> SubtitleConfig { get; set; }
            public class DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfig : TeaModel {
                /// <summary>
                /// <para>The background color of the subtitles.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0xFF0000</para>
                /// </summary>
                [NameInMap("BgColor")]
                [Validation(Required=false)]
                public string BgColor { get; set; }

                /// <summary>
                /// <para>The size of the background image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.09</para>
                /// </summary>
                [NameInMap("BgWidthNormalized")]
                [Validation(Required=false)]
                public float? BgWidthNormalized { get; set; }

                /// <summary>
                /// <para>The font weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.05</para>
                /// </summary>
                [NameInMap("BorderWidthNormalized")]
                [Validation(Required=false)]
                public float? BorderWidthNormalized { get; set; }

                /// <summary>
                /// <para>The description of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>live AI subtitle template</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The language to which the subtitles are translated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh-CN</para>
                /// </summary>
                [NameInMap("DstLanguage")]
                [Validation(Required=false)]
                public string DstLanguage { get; set; }

                /// <summary>
                /// <para>The font color.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0xFFFFFF</para>
                /// </summary>
                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                /// <summary>
                /// <para>The font.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AlibabaPuHuiTi-Regular</para>
                /// </summary>
                [NameInMap("FontName")]
                [Validation(Required=false)]
                public string FontName { get; set; }

                /// <summary>
                /// <para>The font size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.037</para>
                /// </summary>
                [NameInMap("FontSizeNormalized")]
                [Validation(Required=false)]
                public string FontSizeNormalized { get; set; }

                /// <summary>
                /// <para>The height of the preview image.</para>
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

                /// <summary>
                /// <para>The position of the subtitles.</para>
                /// </summary>
                [NameInMap("PositionNormalized")]
                [Validation(Required=false)]
                public DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfigPositionNormalized PositionNormalized { get; set; }
                public class DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfigPositionNormalized : TeaModel {
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public List<float?> Position { get; set; }

                }

                /// <summary>
                /// <para>The ID of the subtitle rule.</para>
                /// </summary>
                [NameInMap("RulesRefer")]
                [Validation(Required=false)]
                public DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfigRulesRefer RulesRefer { get; set; }
                public class DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfigRulesRefer : TeaModel {
                    [NameInMap("RulesId")]
                    [Validation(Required=false)]
                    public List<string> RulesId { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the source language of the subtitle is displayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ShowSourceLan")]
                [Validation(Required=false)]
                public int? ShowSourceLan { get; set; }

                /// <summary>
                /// <para>The source language of the subtitles.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh-CN</para>
                /// </summary>
                [NameInMap("SrcLanguage")]
                [Validation(Required=false)]
                public string SrcLanguage { get; set; }

                /// <summary>
                /// <para>The ID of the subtitle template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>597991f3-6ef9-4100-9238-82951de1****</para>
                /// </summary>
                [NameInMap("SubtitleId")]
                [Validation(Required=false)]
                public string SubtitleId { get; set; }

                /// <summary>
                /// <para>The name of the subtitle template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sub1</para>
                /// </summary>
                [NameInMap("SubtitleName")]
                [Validation(Required=false)]
                public string SubtitleName { get; set; }

                /// <summary>
                /// <para>The width of the preview image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                /// <summary>
                /// <para>The number of words per line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("WordPerline")]
                [Validation(Required=false)]
                public int? WordPerline { get; set; }

            }

        }

    }

}
