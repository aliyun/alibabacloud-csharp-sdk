// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterScenesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("SceneList")]
        [Validation(Required=true)]
        public DescribeCasterScenesResponseSceneList SceneList { get; set; }
        public class DescribeCasterScenesResponseSceneList : TeaModel {
            [NameInMap("Scene")]
            [Validation(Required=true)]
            public List<DescribeCasterScenesResponseSceneListScene> Scene { get; set; }
            public class DescribeCasterScenesResponseSceneListScene : TeaModel {
                public string SceneId { get; set; }
                public string SceneName { get; set; }
                public string OutputType { get; set; }
                public string LayoutId { get; set; }
                public string StreamUrl { get; set; }
                public int? Status { get; set; }
                public DescribeCasterScenesResponseSceneListSceneStreamInfos StreamInfos { get; set; }
                public class DescribeCasterScenesResponseSceneListSceneStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=true)]
                    public List<DescribeCasterScenesResponseSceneListSceneStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class DescribeCasterScenesResponseSceneListSceneStreamInfosStreamInfo : TeaModel {
                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=true)]
                        public string TranscodeConfig { get; set; }

                        [NameInMap("VideoFormat")]
                        [Validation(Required=true)]
                        public string VideoFormat { get; set; }

                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=true)]
                        public string OutputStreamUrl { get; set; }

                    }

                }
                public DescribeCasterScenesResponseSceneListSceneComponentIds ComponentIds { get; set; }
                public class DescribeCasterScenesResponseSceneListSceneComponentIds : TeaModel {
                    /// <summary>
                    /// componentId
                    /// </summary>
                    [NameInMap("componentId")]
                    [Validation(Required=true)]
                    public List<string> ComponentId { get; set; }

                }
            }
        };

    }

}
