// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterLayoutsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public DescribeCasterLayoutsResponseBodyLayouts Layouts { get; set; }
        public class DescribeCasterLayoutsResponseBodyLayouts : TeaModel {
            [NameInMap("Layout")]
            [Validation(Required=false)]
            public List<DescribeCasterLayoutsResponseBodyLayoutsLayout> Layout { get; set; }
            public class DescribeCasterLayoutsResponseBodyLayoutsLayout : TeaModel {
                public string LayoutId { get; set; }
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayers AudioLayers { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayers : TeaModel {
                    [NameInMap("AudioLayer")]
                    [Validation(Required=false)]
                    public List<DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayersAudioLayer> AudioLayer { get; set; }
                    public class DescribeCasterLayoutsResponseBodyLayoutsLayoutAudioLayersAudioLayer : TeaModel {
                        [NameInMap("VolumeRate")]
                        [Validation(Required=false)]
                        public float? VolumeRate { get; set; }

                        [NameInMap("FixedDelayDuration")]
                        [Validation(Required=false)]
                        public int? FixedDelayDuration { get; set; }

                        [NameInMap("ValidChannel")]
                        [Validation(Required=false)]
                        public string ValidChannel { get; set; }

                    }

                }
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayers VideoLayers { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayers : TeaModel {
                    [NameInMap("VideoLayer")]
                    [Validation(Required=false)]
                    public List<DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayer> VideoLayer { get; set; }
                    public class DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayer : TeaModel {
                        [NameInMap("FixedDelayDuration")]
                        [Validation(Required=false)]
                        public int? FixedDelayDuration { get; set; }

                        [NameInMap("PositionNormalizeds")]
                        [Validation(Required=false)]
                        public DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayerPositionNormalizeds PositionNormalizeds { get; set; }
                        public class DescribeCasterLayoutsResponseBodyLayoutsLayoutVideoLayersVideoLayerPositionNormalizeds : TeaModel {
                            [NameInMap("Position")]
                            [Validation(Required=false)]
                            public List<string> Position { get; set; }
                        };

                        [NameInMap("HeightNormalized")]
                        [Validation(Required=false)]
                        public float? HeightNormalized { get; set; }

                        [NameInMap("FillMode")]
                        [Validation(Required=false)]
                        public string FillMode { get; set; }

                        [NameInMap("PositionRefer")]
                        [Validation(Required=false)]
                        public string PositionRefer { get; set; }

                        [NameInMap("WidthNormalized")]
                        [Validation(Required=false)]
                        public float? WidthNormalized { get; set; }

                    }

                }
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutMixList MixList { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutMixList : TeaModel {
                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public List<string> LocationId { get; set; }

                }
                public DescribeCasterLayoutsResponseBodyLayoutsLayoutBlendList BlendList { get; set; }
                public class DescribeCasterLayoutsResponseBodyLayoutsLayoutBlendList : TeaModel {
                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public List<string> LocationId { get; set; }

                }
            }
        };

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
