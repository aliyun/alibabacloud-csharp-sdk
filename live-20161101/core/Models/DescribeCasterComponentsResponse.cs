// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterComponentsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Components")]
        [Validation(Required=true)]
        public DescribeCasterComponentsResponseComponents Components { get; set; }
        public class DescribeCasterComponentsResponseComponents : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=true)]
            public List<DescribeCasterComponentsResponseComponentsComponent> Component { get; set; }
            public class DescribeCasterComponentsResponseComponentsComponent : TeaModel {
                public string ComponentId { get; set; }
                public string ComponentName { get; set; }
                public string LocationId { get; set; }
                public string ComponentType { get; set; }
                public string Effect { get; set; }
                public DescribeCasterComponentsResponseComponentsComponentComponentLayer ComponentLayer { get; set; }
                public class DescribeCasterComponentsResponseComponentsComponentComponentLayer : TeaModel {
                    [NameInMap("HeightNormalized")]
                    [Validation(Required=true)]
                    public float? HeightNormalized { get; set; }

                    [NameInMap("WidthNormalized")]
                    [Validation(Required=true)]
                    public float? WidthNormalized { get; set; }

                    [NameInMap("PositionRefer")]
                    [Validation(Required=true)]
                    public string PositionRefer { get; set; }

                    [NameInMap("Transparency")]
                    [Validation(Required=true)]
                    public int? Transparency { get; set; }

                    [NameInMap("PositionNormalizeds")]
                    [Validation(Required=true)]
                    public DescribeCasterComponentsResponseComponentsComponentComponentLayerPositionNormalizeds PositionNormalizeds { get; set; }
                    public class DescribeCasterComponentsResponseComponentsComponentComponentLayerPositionNormalizeds : TeaModel {
                        [NameInMap("Position")]
                        [Validation(Required=true)]
                        public List<string> Position { get; set; }
                    };

                }
                public DescribeCasterComponentsResponseComponentsComponentTextLayerContent TextLayerContent { get; set; }
                public class DescribeCasterComponentsResponseComponentsComponentTextLayerContent : TeaModel {
                    [NameInMap("Text")]
                    [Validation(Required=true)]
                    public string Text { get; set; }

                    [NameInMap("Color")]
                    [Validation(Required=true)]
                    public string Color { get; set; }

                    [NameInMap("FontName")]
                    [Validation(Required=true)]
                    public string FontName { get; set; }

                    [NameInMap("SizeNormalized")]
                    [Validation(Required=true)]
                    public float? SizeNormalized { get; set; }

                    [NameInMap("BorderWidthNormalized")]
                    [Validation(Required=true)]
                    public float? BorderWidthNormalized { get; set; }

                    [NameInMap("BorderColor")]
                    [Validation(Required=true)]
                    public string BorderColor { get; set; }

                }
                public DescribeCasterComponentsResponseComponentsComponentImageLayerContent ImageLayerContent { get; set; }
                public class DescribeCasterComponentsResponseComponentsComponentImageLayerContent : TeaModel {
                    [NameInMap("MaterialId")]
                    [Validation(Required=true)]
                    public string MaterialId { get; set; }

                }
                public DescribeCasterComponentsResponseComponentsComponentCaptionLayerContent CaptionLayerContent { get; set; }
                public class DescribeCasterComponentsResponseComponentsComponentCaptionLayerContent : TeaModel {
                    [NameInMap("LocationId")]
                    [Validation(Required=true)]
                    public string LocationId { get; set; }

                    [NameInMap("PtsOffset")]
                    [Validation(Required=true)]
                    public int? PtsOffset { get; set; }

                    [NameInMap("WordsCount")]
                    [Validation(Required=true)]
                    public int? WordsCount { get; set; }

                    [NameInMap("Color")]
                    [Validation(Required=true)]
                    public string Color { get; set; }

                    [NameInMap("FontName")]
                    [Validation(Required=true)]
                    public string FontName { get; set; }

                    [NameInMap("SizeNormalized")]
                    [Validation(Required=true)]
                    public float? SizeNormalized { get; set; }

                    [NameInMap("BorderWidthNormalized")]
                    [Validation(Required=true)]
                    public float? BorderWidthNormalized { get; set; }

                    [NameInMap("BorderColor")]
                    [Validation(Required=true)]
                    public string BorderColor { get; set; }

                    [NameInMap("WordCountPerLine")]
                    [Validation(Required=true)]
                    public int? WordCountPerLine { get; set; }

                    [NameInMap("WordSpaceNormalized")]
                    [Validation(Required=true)]
                    public float? WordSpaceNormalized { get; set; }

                    [NameInMap("LineSpaceNormalized")]
                    [Validation(Required=true)]
                    public float? LineSpaceNormalized { get; set; }

                }
            }
        };

    }

}
