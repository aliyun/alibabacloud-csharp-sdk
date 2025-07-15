// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartCasterResponseBody : TeaModel {
        /// <summary>
        /// <para>The PGM scenes.</para>
        /// </summary>
        [NameInMap("PgmSceneInfos")]
        [Validation(Required=false)]
        public StartCasterResponseBodyPgmSceneInfos PgmSceneInfos { get; set; }
        public class StartCasterResponseBodyPgmSceneInfos : TeaModel {
            [NameInMap("SceneInfo")]
            [Validation(Required=false)]
            public List<StartCasterResponseBodyPgmSceneInfosSceneInfo> SceneInfo { get; set; }
            public class StartCasterResponseBodyPgmSceneInfosSceneInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b5f8c837-ceeb-424f-b30b-68e94e86****</para>
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                /// <summary>
                /// <para>The stream relay URLs.</para>
                /// </summary>
                [NameInMap("StreamInfos")]
                [Validation(Required=false)]
                public StartCasterResponseBodyPgmSceneInfosSceneInfoStreamInfos StreamInfos { get; set; }
                public class StartCasterResponseBodyPgmSceneInfosSceneInfoStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=false)]
                    public List<StartCasterResponseBodyPgmSceneInfosSceneInfoStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class StartCasterResponseBodyPgmSceneInfosSceneInfoStreamInfosStreamInfo : TeaModel {
                        /// <summary>
                        /// <para>The URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rtmp://abclive/caster/example.net</para>
                        /// </summary>
                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=false)]
                        public string OutputStreamUrl { get; set; }

                        /// <summary>
                        /// <para>The transcoding configuration. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>lsd</b>: standard definition</description></item>
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
                        /// <item><description><b>rtmp</b></description></item>
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
                /// <para>The streaming URL of the PGM scene in the production studio. The value is not a stream relay URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://abclive/caster/example.edu</para>
                /// </summary>
                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The PVW scenes.</para>
        /// </summary>
        [NameInMap("PvwSceneInfos")]
        [Validation(Required=false)]
        public StartCasterResponseBodyPvwSceneInfos PvwSceneInfos { get; set; }
        public class StartCasterResponseBodyPvwSceneInfos : TeaModel {
            [NameInMap("SceneInfo")]
            [Validation(Required=false)]
            public List<StartCasterResponseBodyPvwSceneInfosSceneInfo> SceneInfo { get; set; }
            public class StartCasterResponseBodyPvwSceneInfosSceneInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b5f8c837-ceeb-424f-b30b-68e94e86****</para>
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                /// <summary>
                /// <para>The streaming URL of the PVW scene in the production studio. The value is not a stream relay URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://abclive/caster/example.net</para>
                /// </summary>
                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EBD1AC4-C34D-4AE1-963E-B688A228BE31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
