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
                [NameInMap("CaptionLayerContent")]
                [Validation(Required=false)]
                public DescribeCasterComponentsResponseBodyComponentsComponentCaptionLayerContent CaptionLayerContent { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentCaptionLayerContent : TeaModel {
                    [NameInMap("BorderColor")]
                    [Validation(Required=false)]
                    public string BorderColor { get; set; }

                    [NameInMap("BorderWidthNormalized")]
                    [Validation(Required=false)]
                    public float? BorderWidthNormalized { get; set; }

                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    [NameInMap("FontName")]
                    [Validation(Required=false)]
                    public string FontName { get; set; }

                    [NameInMap("LineSpaceNormalized")]
                    [Validation(Required=false)]
                    public float? LineSpaceNormalized { get; set; }

                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public string LocationId { get; set; }

                    [NameInMap("PtsOffset")]
                    [Validation(Required=false)]
                    public int? PtsOffset { get; set; }

                    [NameInMap("ShowSourceLan")]
                    [Validation(Required=false)]
                    public bool? ShowSourceLan { get; set; }

                    [NameInMap("SizeNormalized")]
                    [Validation(Required=false)]
                    public float? SizeNormalized { get; set; }

                    [NameInMap("SourceLan")]
                    [Validation(Required=false)]
                    public string SourceLan { get; set; }

                    [NameInMap("TargetLan")]
                    [Validation(Required=false)]
                    public string TargetLan { get; set; }

                    [NameInMap("WordCountPerLine")]
                    [Validation(Required=false)]
                    public int? WordCountPerLine { get; set; }

                    [NameInMap("WordSpaceNormalized")]
                    [Validation(Required=false)]
                    public float? WordSpaceNormalized { get; set; }

                    [NameInMap("WordsCount")]
                    [Validation(Required=false)]
                    public int? WordsCount { get; set; }

                }

                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                [NameInMap("ComponentLayer")]
                [Validation(Required=false)]
                public DescribeCasterComponentsResponseBodyComponentsComponentComponentLayer ComponentLayer { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentComponentLayer : TeaModel {
                    [NameInMap("HeightNormalized")]
                    [Validation(Required=false)]
                    public float? HeightNormalized { get; set; }

                    [NameInMap("PositionNormalizeds")]
                    [Validation(Required=false)]
                    public DescribeCasterComponentsResponseBodyComponentsComponentComponentLayerPositionNormalizeds PositionNormalizeds { get; set; }
                    public class DescribeCasterComponentsResponseBodyComponentsComponentComponentLayerPositionNormalizeds : TeaModel {
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public List<float?> Position { get; set; }

                    }

                    [NameInMap("PositionRefer")]
                    [Validation(Required=false)]
                    public string PositionRefer { get; set; }

                    [NameInMap("Transparency")]
                    [Validation(Required=false)]
                    public int? Transparency { get; set; }

                    [NameInMap("WidthNormalized")]
                    [Validation(Required=false)]
                    public float? WidthNormalized { get; set; }

                }

                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                [NameInMap("ImageLayerContent")]
                [Validation(Required=false)]
                public DescribeCasterComponentsResponseBodyComponentsComponentImageLayerContent ImageLayerContent { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentImageLayerContent : TeaModel {
                    [NameInMap("MaterialId")]
                    [Validation(Required=false)]
                    public string MaterialId { get; set; }

                }

                [NameInMap("LocationId")]
                [Validation(Required=false)]
                public string LocationId { get; set; }

                [NameInMap("TextLayerContent")]
                [Validation(Required=false)]
                public DescribeCasterComponentsResponseBodyComponentsComponentTextLayerContent TextLayerContent { get; set; }
                public class DescribeCasterComponentsResponseBodyComponentsComponentTextLayerContent : TeaModel {
                    [NameInMap("BorderColor")]
                    [Validation(Required=false)]
                    public string BorderColor { get; set; }

                    [NameInMap("BorderWidthNormalized")]
                    [Validation(Required=false)]
                    public float? BorderWidthNormalized { get; set; }

                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    [NameInMap("FontName")]
                    [Validation(Required=false)]
                    public string FontName { get; set; }

                    [NameInMap("SizeNormalized")]
                    [Validation(Required=false)]
                    public float? SizeNormalized { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3be7ade8-d907-483c-b24a-0dad45******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
