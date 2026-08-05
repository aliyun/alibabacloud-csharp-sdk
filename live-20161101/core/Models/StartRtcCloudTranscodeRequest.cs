// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartRtcCloudTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application to which the channel belongs. The ID can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>********-7074-<b><b>-9ef5-85c19a4</b></b>*</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the channel to which the user to be transcoded belongs. The ID can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myChannel</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The parameters for the input stream subscription.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputParam")]
        [Validation(Required=false)]
        public StartRtcCloudTranscodeRequestInputParam InputParam { get; set; }
        public class StartRtcCloudTranscodeRequestInputParam : TeaModel {
            /// <summary>
            /// <para>The input parameters for a single-stream subscription.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SingleSubUserParam")]
            [Validation(Required=false)]
            public StartRtcCloudTranscodeRequestInputParamSingleSubUserParam SingleSubUserParam { get; set; }
            public class StartRtcCloudTranscodeRequestInputParamSingleSubUserParam : TeaModel {
                /// <summary>
                /// <para>The type of the video input stream. This parameter is valid only if the subscribed media type includes a video stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): The camera stream.</para>
                /// </description></item>
                /// <item><description><para>1: The screen sharing stream. (This value is not supported. The setting is invalid.)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public long? SourceType { get; set; }

                /// <summary>
                /// <para>The media type of the subscribed stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): The original stream, which includes both the audio and video streams.</para>
                /// </description></item>
                /// <item><description><para>1: The audio-only stream. (This value is not supported. The setting is invalid.)</para>
                /// </description></item>
                /// <item><description><para>2: The video-only stream. (This value is not supported. The setting is invalid.)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public long? StreamType { get; set; }

                /// <summary>
                /// <para>The ID of the user whose stream you want to subscribe to.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The idle timeout period in seconds. If a task cannot subscribe to the specified streamer\&quot;s stream and remains idle for longer than this period, the task automatically stops. The value must be an integer from 10 to 14,400. The default value is 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public long? MaxIdleTime { get; set; }

        /// <summary>
        /// <para>The parameters for the transcoded output.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutputParams")]
        [Validation(Required=false)]
        public List<StartRtcCloudTranscodeRequestOutputParams> OutputParams { get; set; }
        public class StartRtcCloudTranscodeRequestOutputParams : TeaModel {
            /// <summary>
            /// <para>The ID of the channel to which the transcoded stream is pushed. The ID can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 64 characters. (Pushing streams to a different channel is not supported. This setting is invalid.)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myChannel</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The name of the transcoding template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>alimcopy</para>
            /// </description></item>
            /// <item><description><para>lld</para>
            /// </description></item>
            /// <item><description><para>lsd</para>
            /// </description></item>
            /// <item><description><para>lhd</para>
            /// </description></item>
            /// <item><description><para>lud</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lhd</para>
            /// </summary>
            [NameInMap("TranscodeTemplate")]
            [Validation(Required=false)]
            public string TranscodeTemplate { get; set; }

            /// <summary>
            /// <para>The user ID for the transcoded stream in the destination channel. This ID must be unique within the channel.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userA_360p</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The token required to push the transcoded stream to the channel. For more information, see <a href="https://www.alibabacloud.com/help/en/apsaravideo-live/latest/token-based-authentication">Token-based authentication</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJhcHBpZCI********</para>
            /// </summary>
            [NameInMap("UserToken")]
            [Validation(Required=false)]
            public string UserToken { get; set; }

        }

    }

}
