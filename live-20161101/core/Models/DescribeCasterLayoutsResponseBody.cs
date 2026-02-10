// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterLayoutsResponseBody : TeaModel {
        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public DescribeCasterLayoutsResponseBodyLayouts Layouts { get; set; }
        public class DescribeCasterLayoutsResponseBodyLayouts : TeaModel {
            [NameInMap("Layout")]
            [Validation(Required=false)]
            public List<DescribeCasterLayoutsResponseBodyLayoutsLayout> Layout { get; set; }
            public class DescribeCasterLayoutsResponseBodyLayoutsLayout : TeaModel {
                [NameInMap("AudioLayers")]
                [Validation(Required=false)]
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayers AudioLayers { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayers : TeaModel {
                    [NameInMap("AudioLayer")]
                    [Validation(Required=false)]
                    public List<DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayersAudioLayer> AudioLayer { get; set; }
                    public class DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayersAudioLayer : TeaModel {
                        [NameInMap("FixedDelayDuration")]
                        [Validation(Required=false)]
                        public int? FixedDelayDuration { get; set; }

                        [NameInMap("ValidChannel")]
                        [Validation(Required=false)]
                        public string ValidChannel { get; set; }

                        [NameInMap("VolumeRate")]
                        [Validation(Required=false)]
                        public float? VolumeRate { get; set; }

                    }

                }

                [NameInMap("BlendList")]
                [Validation(Required=false)]
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutBlendList BlendList { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutBlendList : TeaModel {
                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public List<string> LocationId { get; set; }

                }

                [NameInMap("LayoutId")]
                [Validation(Required=false)]
                public string LayoutId { get; set; }

                [NameInMap("MixList")]
                [Validation(Required=false)]
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutMixList MixList { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutMixList : TeaModel {
                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public List<string> LocationId { get; set; }

                }

                [NameInMap("VideoLayers")]
                [Validation(Required=false)]
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayers VideoLayers { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayers : TeaModel {
                    [NameInMap("VideoLayer")]
                    [Validation(Required=false)]
                    public List<DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayer> VideoLayer { get; set; }
                    public class DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayer : TeaModel {
                        [NameInMap("FillMode")]
                        [Validation(Required=false)]
                        public string FillMode { get; set; }

                        [NameInMap("FixedDelayDuration")]
                        [Validation(Required=false)]
                        public int? FixedDelayDuration { get; set; }

                        [NameInMap("HeightNormalized")]
                        [Validation(Required=false)]
                        public float? HeightNormalized { get; set; }

                        [NameInMap("PositionNormalizeds")]
                        [Validation(Required=false)]
                        public DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayerPositionNormalizeds PositionNormalizeds { get; set; }
                        public class DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayerPositionNormalizeds : TeaModel {
                            [NameInMap("Position")]
                            [Validation(Required=false)]
                            public List<float?> Position { get; set; }

                        }

                        [NameInMap("PositionRefer")]
                        [Validation(Required=false)]
                        public string PositionRefer { get; set; }

                        [NameInMap("WidthNormalized")]
                        [Validation(Required=false)]
                        public float? WidthNormalized { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The normalized value of the width of the video layer image.</para>
        /// <list type="bullet">
        /// <item><description>If the FillMode parameter of the video layer is set to none, the height of the video image is scaled based on this parameter. The default value is <b>0</b>, which indicates that the video image is displayed in the original size.</description></item>
        /// <item><description>If the FillMode parameter of the video layer is set to fit, the value of the parameter is greater than <b>0</b>.</description></item>
        /// </list>
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
