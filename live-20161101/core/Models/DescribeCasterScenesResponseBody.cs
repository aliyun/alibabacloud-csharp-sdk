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

        /// <summary>
        /// <para>The scenes.</para>
        /// </summary>
        [NameInMap("SceneList")]
        [Validation(Required=false)]
        public DescribeCasterScenesResponseBodySceneList SceneList { get; set; }
        public class DescribeCasterScenesResponseBodySceneList : TeaModel {
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public List<DescribeCasterScenesResponseBodySceneListScene> Scene { get; set; }
            public class DescribeCasterScenesResponseBodySceneListScene : TeaModel {
                /// <summary>
                /// <para>The components.</para>
                /// </summary>
                [NameInMap("ComponentIds")]
                [Validation(Required=false)]
                public DescribeCasterScenesResponseBodySceneListSceneComponentIds ComponentIds { get; set; }
                public class DescribeCasterScenesResponseBodySceneListSceneComponentIds : TeaModel {
                    [NameInMap("componentId")]
                    [Validation(Required=false)]
                    public List<string> ComponentId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the layout.</para>
                /// 
                /// <b>Example:</b>
                /// <para>37cb2f8b-f152-4338-b928-6704f71d****</para>
                /// </summary>
                [NameInMap("LayoutId")]
                [Validation(Required=false)]
                public string LayoutId { get; set; }

                /// <summary>
                /// <para>Indicates whether the output video is in PVW mode or PGM mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: in PVW mode.</description></item>
                /// <item><description><b>1</b>: in PGM mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OutputType")]
                [Validation(Required=false)]
                public string OutputType { get; set; }

                /// <summary>
                /// <para>The ID of the scene. You can use the ID as a request parameter in the API operation that is used to modify the audio configurations of the scene, query the audio configurations of the scene, start the scene, or stop the scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b5f8c837-ceeb-424f-b30b-68e94e86****</para>
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                /// <summary>
                /// <para>The name of the scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>scene1</para>
                /// </summary>
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                /// <summary>
                /// <para>The status of the scene. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: disabled</description></item>
                /// <item><description><b>1</b>: enabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The information about the stream.</para>
                /// </summary>
                [NameInMap("StreamInfos")]
                [Validation(Required=false)]
                public DescribeCasterScenesResponseBodySceneListSceneStreamInfos StreamInfos { get; set; }
                public class DescribeCasterScenesResponseBodySceneListSceneStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=false)]
                    public List<DescribeCasterScenesResponseBodySceneListSceneStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class DescribeCasterScenesResponseBodySceneListSceneStreamInfosStreamInfo : TeaModel {
                        /// <summary>
                        /// <para>The streaming URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://live/caster/example.net">http://live/caster/example.net</a></para>
                        /// </summary>
                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=false)]
                        public string OutputStreamUrl { get; set; }

                        /// <summary>
                        /// <para>The transcoding configuration. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>sd</b>: standard definition</description></item>
                        /// <item><description><b>lld</b>: low definition</description></item>
                        /// <item><description><b>lud</b>: ultra-high definition</description></item>
                        /// <item><description><b>lhd</b>: high definition</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>lld</para>
                        /// </summary>
                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=false)]
                        public string TranscodeConfig { get; set; }

                        /// <summary>
                        /// <para>The format. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>flv</b></description></item>
                        /// <item><description><b>mp4</b></description></item>
                        /// <item><description><b>m3u8</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>flv</para>
                        /// </summary>
                        [NameInMap("VideoFormat")]
                        [Validation(Required=false)]
                        public string VideoFormat { get; set; }

                    }

                }

                /// <summary>
                /// <para>The URL of the output stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://developer.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****</para>
                /// </summary>
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
