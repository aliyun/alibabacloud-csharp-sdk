// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class QueryAvatarProjectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000222</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("frames")]
        [Validation(Required=false)]
        public List<QueryAvatarProjectResponseBodyFrames> Frames { get; set; }
        public class QueryAvatarProjectResponseBodyFrames : TeaModel {
            [NameInMap("layers")]
            [Validation(Required=false)]
            public List<QueryAvatarProjectResponseBodyFramesLayers> Layers { get; set; }
            public class QueryAvatarProjectResponseBodyFramesLayers : TeaModel {
                [NameInMap("height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public QueryAvatarProjectResponseBodyFramesLayersMaterial Material { get; set; }
                public class QueryAvatarProjectResponseBodyFramesLayersMaterial : TeaModel {
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("positionX")]
                [Validation(Required=false)]
                public int? PositionX { get; set; }

                [NameInMap("positionY")]
                [Validation(Required=false)]
                public int? PositionY { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("videoScript")]
            [Validation(Required=false)]
            public QueryAvatarProjectResponseBodyFramesVideoScript VideoScript { get; set; }
            public class QueryAvatarProjectResponseBodyFramesVideoScript : TeaModel {
                [NameInMap("speedRate")]
                [Validation(Required=false)]
                public string SpeedRate { get; set; }

                [NameInMap("voiceTemplateId")]
                [Validation(Required=false)]
                public string VoiceTemplateId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>doc_test_3</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2C331582-7390-5949-8D9A-AC8239185B37</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resSpecType")]
        [Validation(Required=false)]
        public string ResSpecType { get; set; }

        [NameInMap("scaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DEPLOYING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
