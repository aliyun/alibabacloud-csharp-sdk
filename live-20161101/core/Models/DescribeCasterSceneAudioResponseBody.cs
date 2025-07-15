// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterSceneAudioResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the audio layers.</para>
        /// </summary>
        [NameInMap("AudioLayers")]
        [Validation(Required=false)]
        public DescribeCasterSceneAudioResponseBodyAudioLayers AudioLayers { get; set; }
        public class DescribeCasterSceneAudioResponseBodyAudioLayers : TeaModel {
            [NameInMap("AudioLayer")]
            [Validation(Required=false)]
            public List<DescribeCasterSceneAudioResponseBodyAudioLayersAudioLayer> AudioLayer { get; set; }
            public class DescribeCasterSceneAudioResponseBodyAudioLayersAudioLayer : TeaModel {
                /// <summary>
                /// <para>The fixed delay of the audio layer. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("FixedDelayDuration")]
                [Validation(Required=false)]
                public int? FixedDelayDuration { get; set; }

                /// <summary>
                /// <para>The sound channel type of the audio layer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>left</b>: the left channel</description></item>
                /// <item><description><b>right</b>: the right channel</description></item>
                /// <item><description><b>all</b> (default): both the left and right channels</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("ValidChannel")]
                [Validation(Required=false)]
                public string ValidChannel { get; set; }

                /// <summary>
                /// <para>The volume of the audio layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("VolumeRate")]
                [Validation(Required=false)]
                public float? VolumeRate { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the production studio. You can specify the ID in a request to start a scene in the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97df6b7f-3490-47d2-ac50-88338765****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The audio mode. By default, the audio follows video (AFV) mode is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the audio mixing mode</description></item>
        /// <item><description><b>1</b>: the AFV mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FollowEnable")]
        [Validation(Required=false)]
        public int? FollowEnable { get; set; }

        [NameInMap("MixList")]
        [Validation(Required=false)]
        public DescribeCasterSceneAudioResponseBodyMixList MixList { get; set; }
        public class DescribeCasterSceneAudioResponseBodyMixList : TeaModel {
            [NameInMap("LocationId")]
            [Validation(Required=false)]
            public List<string> LocationId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98745637-3490-47d2-ac50-883387567098</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
