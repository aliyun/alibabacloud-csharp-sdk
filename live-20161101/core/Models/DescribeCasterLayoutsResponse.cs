// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterLayoutsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Layouts")]
        [Validation(Required=true)]
        public DescribeCasterLayoutsResponseLayouts Layouts { get; set; }
        public class DescribeCasterLayoutsResponseLayouts : TeaModel {
            [NameInMap("Layout")]
            [Validation(Required=true)]
            public List<DescribeCasterLayoutsResponseLayoutsLayout> Layout { get; set; }
            public class DescribeCasterLayoutsResponseLayoutsLayout : TeaModel {
                public string LayoutId { get; set; }
                public DescribeCasterLayoutsResponseLayoutsLayoutVideoLayers VideoLayers { get; set; }
                public class DescribeCasterLayoutsResponseLayoutsLayoutVideoLayers : TeaModel {
                    [NameInMap("VideoLayer")]
                    [Validation(Required=true)]
                    public List<DescribeCasterLayoutsResponseLayoutsLayoutVideoLayersVideoLayer> VideoLayer { get; set; }
                    public class DescribeCasterLayoutsResponseLayoutsLayoutVideoLayersVideoLayer : TeaModel {
                        [NameInMap("FillMode")]
                        [Validation(Required=true)]
                        public string FillMode { get; set; }

                        [NameInMap("HeightNormalized")]
                        [Validation(Required=true)]
                        public float? HeightNormalized { get; set; }

                        [NameInMap("WidthNormalized")]
                        [Validation(Required=true)]
                        public float? WidthNormalized { get; set; }

                        [NameInMap("PositionRefer")]
                        [Validation(Required=true)]
                        public string PositionRefer { get; set; }

                        [NameInMap("FixedDelayDuration")]
                        [Validation(Required=true)]
                        public int? FixedDelayDuration { get; set; }

                        [NameInMap("PositionNormalizeds")]
                        [Validation(Required=true)]
                        public DescribeCasterLayoutsResponseLayoutsLayoutVideoLayersVideoLayerPositionNormalizeds PositionNormalizeds { get; set; }
                        public class DescribeCasterLayoutsResponseLayoutsLayoutVideoLayersVideoLayerPositionNormalizeds : TeaModel {
                            [NameInMap("Position")]
                            [Validation(Required=true)]
                            public List<string> Position { get; set; }
                        };

                    }

                }
                public DescribeCasterLayoutsResponseLayoutsLayoutAudioLayers AudioLayers { get; set; }
                public class DescribeCasterLayoutsResponseLayoutsLayoutAudioLayers : TeaModel {
                    [NameInMap("AudioLayer")]
                    [Validation(Required=true)]
                    public List<DescribeCasterLayoutsResponseLayoutsLayoutAudioLayersAudioLayer> AudioLayer { get; set; }
                    public class DescribeCasterLayoutsResponseLayoutsLayoutAudioLayersAudioLayer : TeaModel {
                        [NameInMap("VolumeRate")]
                        [Validation(Required=true)]
                        public float? VolumeRate { get; set; }

                        [NameInMap("ValidChannel")]
                        [Validation(Required=true)]
                        public string ValidChannel { get; set; }

                        [NameInMap("FixedDelayDuration")]
                        [Validation(Required=true)]
                        public int? FixedDelayDuration { get; set; }

                    }

                }
                public DescribeCasterLayoutsResponseLayoutsLayoutBlendList BlendList { get; set; }
                public class DescribeCasterLayoutsResponseLayoutsLayoutBlendList : TeaModel {
                    /// <summary>
                    /// LocationId
                    /// </summary>
                    [NameInMap("LocationId")]
                    [Validation(Required=true)]
                    public List<string> LocationId { get; set; }

                }
                public DescribeCasterLayoutsResponseLayoutsLayoutMixList MixList { get; set; }
                public class DescribeCasterLayoutsResponseLayoutsLayoutMixList : TeaModel {
                    /// <summary>
                    /// LocationId
                    /// </summary>
                    [NameInMap("LocationId")]
                    [Validation(Required=true)]
                    public List<string> LocationId { get; set; }

                }
            }
        };

    }

}
