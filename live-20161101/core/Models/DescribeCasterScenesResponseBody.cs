// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterScenesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("SceneList")]
        [Validation(Required=false)]
        public DescribeCasterScenesResponseBodySceneList SceneList { get; set; }
        public class DescribeCasterScenesResponseBodySceneList : TeaModel {
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public List<DescribeCasterScenesResponseBodySceneListScene> Scene { get; set; }
            public class DescribeCasterScenesResponseBodySceneListScene : TeaModel {
                public int? Status { get; set; }
                public string LayoutId { get; set; }
                public string OutputType { get; set; }
                public DescribeCasterScenesResponseBodySceneListSceneStreamInfos StreamInfos { get; set; }
                public class DescribeCasterScenesResponseBodySceneListSceneStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=false)]
                    public List<DescribeCasterScenesResponseBodySceneListSceneStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class DescribeCasterScenesResponseBodySceneListSceneStreamInfosStreamInfo : TeaModel {
                        [NameInMap("VideoFormat")]
                        [Validation(Required=false)]
                        public string VideoFormat { get; set; }

                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=false)]
                        public string OutputStreamUrl { get; set; }

                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=false)]
                        public string TranscodeConfig { get; set; }

                    }

                }
                public string SceneId { get; set; }
                public string SceneName { get; set; }
                public DescribeCasterScenesResponseBodySceneListSceneComponentIds ComponentIds { get; set; }
                public class DescribeCasterScenesResponseBodySceneListSceneComponentIds : TeaModel {
                    [NameInMap("componentId")]
                    [Validation(Required=false)]
                    public List<string> ComponentId { get; set; }

                }
                public string StreamUrl { get; set; }
            }
        };

    }

}
