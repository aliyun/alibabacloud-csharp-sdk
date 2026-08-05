// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateCasterSceneAudioRequest : TeaModel {
        /// <summary>
        /// <para>The audio configurations.</para>
        /// </summary>
        [NameInMap("AudioLayer")]
        [Validation(Required=false)]
        public List<UpdateCasterSceneAudioRequestAudioLayer> AudioLayer { get; set; }
        public class UpdateCasterSceneAudioRequestAudioLayer : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the features provided by the 3A audio algorithm. This parameter consists of the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enableAgc</b>: (Optional) Specifies whether to enable the automatic gain control (AGC) feature of the 3A algorithm. Valid values: <b>0</b> (disabled, default) and <b>1</b> (enabled).</para>
            /// </description></item>
            /// <item><description><para><b>enableAns</b>: (Optional) Specifies whether to enable the intelligent noise reduction feature of the 3A algorithm. Valid values: <b>0</b> (disabled, default) and <b>1</b> (enabled).</para>
            /// </description></item>
            /// <item><description><para><b>ansMode</b>: (Optional) The mode of the intelligent noise reduction feature. This field is active only when <b>enableAns</b> is set to <b>1</b>. Valid values: <b>0</b> (speech noise reduction, default) and <b>1</b> (music noise reduction).</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For better noise reduction, set ansMode to 1.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para><b>enableBeautify</b>: (Optional) Specifies whether to enable voice beautification. Valid values: <b>0</b> (disabled, default) and <b>1</b> (enabled).</para>
            /// </description></item>
            /// <item><description><para><b>voiceBeautifyMode</b>: (Optional) The voice beautification mode. This field is active only when <b>enableBeautify</b> is set to <b>1</b>. Valid values: <b>0</b> (magnetic male voice, default) and <b>1</b> (fresh female voice).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{   &quot;enableAgc&quot;:0,   &quot;enableAns&quot;:1 }</para>
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            /// <summary>
            /// <para>The fixed latency of the audio layer. This parameter is used to synchronize the audio with captions.</para>
            /// <para>Unit: milliseconds. Valid values: 0 to <b>5000</b>. Default value: <b>0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The sound channels that are used for volume input. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>leftChannel</b>: the left sound channel.</para>
            /// </description></item>
            /// <item><description><para><b>rightChannel</b>: the right sound channel.</para>
            /// </description></item>
            /// <item><description><para><b>all</b> (default): both sound channels.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("ValidChannel")]
            [Validation(Required=false)]
            public string ValidChannel { get; set; }

            /// <summary>
            /// <para>The volume multiplier for the audio stream. Valid values: 0 to <b>10.0</b>. Default value: <b>1.0</b>.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1.0</b>: The original volume is used.</para>
            /// </description></item>
            /// <item><description><para>A value less than <b>1</b> decreases the volume.</para>
            /// </description></item>
            /// <item><description><para>A value greater than <b>1</b> increases the volume.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VolumeRate")]
            [Validation(Required=false)]
            public float? VolumeRate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description><para>If you create a production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, you can obtain the ID from the CasterId parameter in the response.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the LIVE console, go to the <b>LIVE Console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> page to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio in the list on the Cloud Production Studio page is the ID of the production studio.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the AFV mode. If you leave this parameter empty, the last configuration is retained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: audio mixing mode.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: audio-follows-video mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FollowEnable")]
        [Validation(Required=false)]
        public int? FollowEnable { get; set; }

        /// <summary>
        /// <para>The list of associated location IDs. The order of the location IDs must be the same as the order of the audio layers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV01</para>
        /// </summary>
        [NameInMap("MixList")]
        [Validation(Required=false)]
        public List<string> MixList { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the scene. If you query the list of scenes in a production studio by calling the <a href="https://help.aliyun.com/document_detail/2848039.html">DescribeCasterScenes</a> operation, you can obtain the ID from the ComponentId parameter in the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e1****</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
