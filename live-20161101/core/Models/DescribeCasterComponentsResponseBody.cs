// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterComponentsResponseBody : TeaModel {
        [NameInMap("Components")]
        [Validation(Required=false)]
        public DescribeCasterComponentsResponseBodyComponents Components { get; set; }
        public class DescribeCasterComponentsResponseBodyComponents : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<DescribeCasterComponentsResponseBodyComponentsComponent> Component { get; set; }
            public class DescribeCasterComponentsResponseBodyComponentsComponent : TeaModel {
                public DescribeCasterComponentsResponseBodyComponentsComponentTextLayerContent TextLayerContent { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentTextLayerContent : TeaModel {
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    [NameInMap("BorderColor")]
                    [Validation(Required=false)]
                    public string BorderColor { get; set; }

                    [NameInMap("BorderWidthNormalized")]
                    [Validation(Required=false)]
                    public float? BorderWidthNormalized { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("SizeNormalized")]
                    [Validation(Required=false)]
                    public float? SizeNormalized { get; set; }

                    [NameInMap("FontName")]
                    [Validation(Required=false)]
                    public string FontName { get; set; }

                }
                public string Effect { get; set; }
                public string ComponentName { get; set; }
                public DescribeCasterComponentsResponseBodyComponentsComponentComponentLayer ComponentLayer { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentComponentLayer : TeaModel {
                    [NameInMap("Transparency")]
                    [Validation(Required=false)]
                    public int? Transparency { get; set; }

                    [NameInMap("PositionNormalizeds")]
                    [Validation(Required=false)]
                    public DescribeCasterComponentsResponseBodyComponentsComponentComponentLayerPositionNormalizeds PositionNormalizeds { get; set; }
                    public class DescribeCasterComponentsResponseBodyComponentsComponentComponentLayerPositionNormalizeds : TeaModel {
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public List<string> Position { get; set; }
                    };

                    [NameInMap("HeightNormalized")]
                    [Validation(Required=false)]
                    public float? HeightNormalized { get; set; }

                    [NameInMap("PositionRefer")]
                    [Validation(Required=false)]
                    public string PositionRefer { get; set; }

                    [NameInMap("WidthNormalized")]
                    [Validation(Required=false)]
                    public float? WidthNormalized { get; set; }

                }
                public DescribeCasterComponentsResponseBodyComponentsComponentImageLayerContent ImageLayerContent { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentImageLayerContent : TeaModel {
                    [NameInMap("MaterialId")]
                    [Validation(Required=false)]
                    public string MaterialId { get; set; }

                }
                public string ComponentType { get; set; }
                public string LocationId { get; set; }
                public DescribeCasterComponentsResponseBodyComponentsComponentCaptionLayerContent CaptionLayerContent { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentCaptionLayerContent : TeaModel {
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    [NameInMap("WordSpaceNormalized")]
                    [Validation(Required=false)]
                    public float? WordSpaceNormalized { get; set; }

                    [NameInMap("BorderWidthNormalized")]
                    [Validation(Required=false)]
                    public float? BorderWidthNormalized { get; set; }

                    [NameInMap("SourceLan")]
                    [Validation(Required=false)]
                    public string SourceLan { get; set; }

                    [NameInMap("WordCountPerLine")]
                    [Validation(Required=false)]
                    public int? WordCountPerLine { get; set; }

                    [NameInMap("TargetLan")]
                    [Validation(Required=false)]
                    public string TargetLan { get; set; }

                    [NameInMap("BorderColor")]
                    [Validation(Required=false)]
                    public string BorderColor { get; set; }

                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public string LocationId { get; set; }

                    [NameInMap("LineSpaceNormalized")]
                    [Validation(Required=false)]
                    public float? LineSpaceNormalized { get; set; }

                    [NameInMap("SizeNormalized")]
                    [Validation(Required=false)]
                    public float? SizeNormalized { get; set; }

                    [NameInMap("ShowSourceLan")]
                    [Validation(Required=false)]
                    public bool? ShowSourceLan { get; set; }

                    [NameInMap("WordsCount")]
                    [Validation(Required=false)]
                    public int? WordsCount { get; set; }

                    [NameInMap("FontName")]
                    [Validation(Required=false)]
                    public string FontName { get; set; }

                    [NameInMap("PtsOffset")]
                    [Validation(Required=false)]
                    public int? PtsOffset { get; set; }

                }
                public string ComponentId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
