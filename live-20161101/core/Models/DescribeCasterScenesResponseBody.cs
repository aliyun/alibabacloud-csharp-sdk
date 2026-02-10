// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterScenesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The ID of the scene.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SceneList")]
        [Validation(Required=false)]
        public DescribeCasterScenesResponseBodySceneList SceneList { get; set; }
        public class DescribeCasterScenesResponseBodySceneList : TeaModel {
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public List<DescribeCasterScenesResponseBodySceneListScene> Scene { get; set; }
            public class DescribeCasterScenesResponseBodySceneListScene : TeaModel {
                [NameInMap("ComponentIds")]
                [Validation(Required=false)]
                public DescribeCasterScenesResponseBodySceneListSceneComponentIds ComponentIds { get; set; }
                public class DescribeCasterScenesResponseBodySceneListSceneComponentIds : TeaModel {
                    [NameInMap("componentId")]
                    [Validation(Required=false)]
                    public List<string> ComponentId { get; set; }

                }

                [NameInMap("LayoutId")]
                [Validation(Required=false)]
                public string LayoutId { get; set; }

                [NameInMap("OutputType")]
                [Validation(Required=false)]
                public string OutputType { get; set; }

                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("StreamInfos")]
                [Validation(Required=false)]
                public DescribeCasterScenesResponseBodySceneListSceneStreamInfos StreamInfos { get; set; }
                public class DescribeCasterScenesResponseBodySceneListSceneStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=false)]
                    public List<DescribeCasterScenesResponseBodySceneListSceneStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class DescribeCasterScenesResponseBodySceneListSceneStreamInfosStreamInfo : TeaModel {
                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=false)]
                        public string OutputStreamUrl { get; set; }

                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=false)]
                        public string TranscodeConfig { get; set; }

                        [NameInMap("VideoFormat")]
                        [Validation(Required=false)]
                        public string VideoFormat { get; set; }

                    }

                }

                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
