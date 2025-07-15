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
            /// <para>Specifies whether to enable the features provided by the audio 3A algorithms. This parameter consists of the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>enableAgc</b>: specifies whether to enable automatic gain control (AGC). This field is optional. Valid values: 0 and 1. <b>0</b> is the default value, which specifies that AGC is disabled. <b>1</b> specifies that AGC is enabled.</description></item>
            /// <item><description><b>enableAns</b>: specifies whether to enable active noise suppression (ANS). This field is optional. Valid values: 0 and 1. <b>0</b> is the default value, which specifies that ANS is disabled. <b>1</b> specifies that ANS is enabled.</description></item>
            /// <item><description><b>ansMode</b>: specifies the mode for ANS. This field is optional and takes effect only if you set <b>enableAns</b> to <b>1</b>. Valid values: 0 and 1. <b>0</b> is the default value, which specifies the speech noise reduction mode. <b>1</b> specifies the music noise reduction mode.</description></item>
            /// </list>
            /// <remarks>
            /// <para> To ensure a better noise reduction effect, we recommend that you set ansMode to 1.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><b>enableBeautify</b>: specifies whether to enable voice change. This field is optional. Valid values: 0 and 1. <b>0</b> is the default value, which specifies that voice change is disabled. <b>1</b> specifies that voice change is enabled.</description></item>
            /// <item><description><b>voiceBeautifyMode</b>: specifies the mode for voice change. This field is optional and takes effect only if you set <b>enableBeautify</b> to <b>1</b>. Valid values: 0 and 1. <b>0</b> is the default value, which specifies the magnetic male voice mode. <b>1</b> specifies the fresh female voice mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{   &quot;enableAgc&quot;:0,   &quot;enableAns&quot;:1 }</para>
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            /// <summary>
            /// <para>The fixed delay of the audio layer. This parameter is used to synchronize the audio with subtitles.</para>
            /// <para>Unit: milliseconds. Valid values: <b>0 to 5000</b>. Default value: <b>0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The sound channels that are used for volume input in the audio layer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>leftChannel</b>: the left channel</description></item>
            /// <item><description><b>rightChannel</b>: the right channel</description></item>
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
            /// <para>The multiple of the original volume at which the audio layer plays audio. Valid values: <b>0 to 10.0</b>. Default value: <b>1.0</b>.</para>
            /// <list type="bullet">
            /// <item><description><b>1.0</b>: specifies that the audio layer plays audio at the original volume.</description></item>
            /// <item><description>A value smaller than <b>1</b>: specifies that the audio layer plays audio at a volume that is less than the original volume.</description></item>
            /// <item><description>A value greater than <b>1</b>: specifies that the audio layer plays audio at a volume that is more than the original volume.</description></item>
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
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
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
        /// <para>The audio mode. By default, the AFV mode is used. If you do not specify this parameter, the scene retains the last configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the audio mixing mode.</description></item>
        /// <item><description><b>1</b>: the AFV mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FollowEnable")]
        [Validation(Required=false)]
        public int? FollowEnable { get; set; }

        /// <summary>
        /// <para>The location IDs of the audio layers, which are in the same order as the audio layers.</para>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the scene. If you call the <a href="https://help.aliyun.com/document_detail/2848039.html">DescribeCasterScenes</a> operation to query scenes of the production studio, check the value of the response parameter ComponentId to obtain the ID.</para>
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
