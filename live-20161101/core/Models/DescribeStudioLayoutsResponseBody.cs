// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeStudioLayoutsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StudioLayouts")]
        [Validation(Required=false)]
        public List<DescribeStudioLayoutsResponseBodyStudioLayouts> StudioLayouts { get; set; }
        public class DescribeStudioLayoutsResponseBodyStudioLayouts : TeaModel {
            [NameInMap("BgImageConfig")]
            [Validation(Required=false)]
            public DescribeStudioLayoutsResponseBodyStudioLayoutsBgImageConfig BgImageConfig { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsBgImageConfig : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("LocationId")]
                [Validation(Required=false)]
                public string LocationId { get; set; }

                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public string MaterialId { get; set; }

            }

            [NameInMap("CommonConfig")]
            [Validation(Required=false)]
            public DescribeStudioLayoutsResponseBodyStudioLayoutsCommonConfig CommonConfig { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsCommonConfig : TeaModel {
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("VideoResourceId")]
                [Validation(Required=false)]
                public string VideoResourceId { get; set; }

            }

            [NameInMap("LayerOrderConfigList")]
            [Validation(Required=false)]
            public List<DescribeStudioLayoutsResponseBodyStudioLayoutsLayerOrderConfigList> LayerOrderConfigList { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsLayerOrderConfigList : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            [NameInMap("LayoutName")]
            [Validation(Required=false)]
            public string LayoutName { get; set; }

            [NameInMap("LayoutType")]
            [Validation(Required=false)]
            public string LayoutType { get; set; }

            [NameInMap("MediaInputConfigList")]
            [Validation(Required=false)]
            public List<DescribeStudioLayoutsResponseBodyStudioLayoutsMediaInputConfigList> MediaInputConfigList { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsMediaInputConfigList : TeaModel {
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("FillMode")]
                [Validation(Required=false)]
                public string FillMode { get; set; }

                [NameInMap("HeightNormalized")]
                [Validation(Required=false)]
                public float? HeightNormalized { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ImageMaterialId")]
                [Validation(Required=false)]
                public string ImageMaterialId { get; set; }

                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("PositionNormalized")]
                [Validation(Required=false)]
                public List<float?> PositionNormalized { get; set; }

                [NameInMap("PositionRefer")]
                [Validation(Required=false)]
                public string PositionRefer { get; set; }

                [NameInMap("VideoResourceId")]
                [Validation(Required=false)]
                public string VideoResourceId { get; set; }

                [NameInMap("WidthNormalized")]
                [Validation(Required=false)]
                public float? WidthNormalized { get; set; }

            }

            [NameInMap("ScreenInputConfigList")]
            [Validation(Required=false)]
            public List<DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigList> ScreenInputConfigList { get; set; }
            public class DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigList : TeaModel {
                [NameInMap("AudioConfig")]
                [Validation(Required=false)]
                public DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigListAudioConfig AudioConfig { get; set; }
                public class DescribeStudioLayoutsResponseBodyStudioLayoutsScreenInputConfigListAudioConfig : TeaModel {
                    [NameInMap("ValidChannel")]
                    [Validation(Required=false)]
                    public string ValidChannel { get; set; }

                    [NameInMap("VolumeRate")]
                    [Validation(Required=false)]
                    public float? VolumeRate { get; set; }

                }

                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                [NameInMap("HeightNormalized")]
                [Validation(Required=false)]
                public float? HeightNormalized { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("OnlyAudio")]
                [Validation(Required=false)]
                public bool? OnlyAudio { get; set; }

                [NameInMap("PortraitType")]
                [Validation(Required=false)]
                public int? PortraitType { get; set; }

                [NameInMap("PositionX")]
                [Validation(Required=false)]
                public string PositionX { get; set; }

                [NameInMap("PositionY")]
                [Validation(Required=false)]
                public string PositionY { get; set; }

                [NameInMap("VideoResourceId")]
                [Validation(Required=false)]
                public string VideoResourceId { get; set; }

            }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
