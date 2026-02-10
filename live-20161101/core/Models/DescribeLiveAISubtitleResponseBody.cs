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

        [NameInMap("SubtitleConfigs")]
        [Validation(Required=false)]
        public DescribeLiveAISubtitleResponseBodySubtitleConfigs SubtitleConfigs { get; set; }
        public class DescribeLiveAISubtitleResponseBodySubtitleConfigs : TeaModel {
            [NameInMap("SubtitleConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfig> SubtitleConfig { get; set; }
            public class DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfig : TeaModel {
                [NameInMap("BgColor")]
                [Validation(Required=false)]
                public string BgColor { get; set; }

                [NameInMap("BgWidthNormalized")]
                [Validation(Required=false)]
                public float? BgWidthNormalized { get; set; }

                [NameInMap("BorderWidthNormalized")]
                [Validation(Required=false)]
                public float? BorderWidthNormalized { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DstLanguage")]
                [Validation(Required=false)]
                public string DstLanguage { get; set; }

                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                [NameInMap("FontName")]
                [Validation(Required=false)]
                public string FontName { get; set; }

                [NameInMap("FontSizeNormalized")]
                [Validation(Required=false)]
                public string FontSizeNormalized { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("MaxLines")]
                [Validation(Required=false)]
                public int? MaxLines { get; set; }

                [NameInMap("PositionNormalized")]
                [Validation(Required=false)]
                public DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfigPositionNormalized PositionNormalized { get; set; }
                public class DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfigPositionNormalized : TeaModel {
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public List<float?> Position { get; set; }

                }

                [NameInMap("RulesRefer")]
                [Validation(Required=false)]
                public DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfigRulesRefer RulesRefer { get; set; }
                public class DescribeLiveAISubtitleResponseBodySubtitleConfigsSubtitleConfigRulesRefer : TeaModel {
                    [NameInMap("RulesId")]
                    [Validation(Required=false)]
                    public List<string> RulesId { get; set; }

                }

                [NameInMap("ShowSourceLan")]
                [Validation(Required=false)]
                public int? ShowSourceLan { get; set; }

                [NameInMap("SrcLanguage")]
                [Validation(Required=false)]
                public string SrcLanguage { get; set; }

                [NameInMap("SubtitleId")]
                [Validation(Required=false)]
                public string SubtitleId { get; set; }

                [NameInMap("SubtitleName")]
                [Validation(Required=false)]
                public string SubtitleName { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                [NameInMap("WordPerline")]
                [Validation(Required=false)]
                public int? WordPerline { get; set; }

            }

        }

    }

}
