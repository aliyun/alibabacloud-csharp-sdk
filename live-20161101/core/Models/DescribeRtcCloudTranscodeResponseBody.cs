// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRtcCloudTranscodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the cloud transcoding task.</para>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public DescribeRtcCloudTranscodeResponseBodyTaskInfo TaskInfo { get; set; }
        public class DescribeRtcCloudTranscodeResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>********-7074-<b><b>-9ef5-85c19a4</b></b>*</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myChannel</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The subscription input parameters.</para>
            /// </summary>
            [NameInMap("InputParam")]
            [Validation(Required=false)]
            public DescribeRtcCloudTranscodeResponseBodyTaskInfoInputParam InputParam { get; set; }
            public class DescribeRtcCloudTranscodeResponseBodyTaskInfoInputParam : TeaModel {
                /// <summary>
                /// <para>The single-stream subscription input parameters.</para>
                /// </summary>
                [NameInMap("SingleSubUserParam")]
                [Validation(Required=false)]
                public DescribeRtcCloudTranscodeResponseBodyTaskInfoInputParamSingleSubUserParam SingleSubUserParam { get; set; }
                public class DescribeRtcCloudTranscodeResponseBodyTaskInfoInputParamSingleSubUserParam : TeaModel {
                    /// <summary>
                    /// <para>The video input stream type of the subscription.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public long? SourceType { get; set; }

                    /// <summary>
                    /// <para>The media type of the subscribed user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StreamType")]
                    [Validation(Required=false)]
                    public long? StreamType { get; set; }

                    /// <summary>
                    /// <para>The user ID of the subscribed user.</para>
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
            /// <para>The idle timeout period. If the task remains idle for longer than the MaxIdleTime value, the task is automatically stopped. Unit: seconds. Valid values: 10 to 14400 (maximum of 4 hours). Default value: 300.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public long? MaxIdleTime { get; set; }

            /// <summary>
            /// <para>The transcoding output parameters.</para>
            /// </summary>
            [NameInMap("OutputParams")]
            [Validation(Required=false)]
            public List<DescribeRtcCloudTranscodeResponseBodyTaskInfoOutputParams> OutputParams { get; set; }
            public class DescribeRtcCloudTranscodeResponseBodyTaskInfoOutputParams : TeaModel {
                /// <summary>
                /// <para>The channel ID to which the transcoded stream is relayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myChannel</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The transcoding template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lhd</para>
                /// </summary>
                [NameInMap("TranscodeTemplate")]
                [Validation(Required=false)]
                public string TranscodeTemplate { get; set; }

                /// <summary>
                /// <para>The user ID in the channel to which the transcoded stream is relayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userA_360p</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The user token required to relay the transcoded stream to the channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eyJhcHBpZCI********</para>
                /// </summary>
                [NameInMap("UserToken")]
                [Validation(Required=false)]
                public string UserToken { get; set; }

            }

            /// <summary>
            /// <para>The status of the cloud transcoding task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STARTING</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>RECOVERING</description></item>
            /// <item><description>STOPPED.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The cloud transcoding task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>73-8501-</b></b>-8ac1-72295a</b>****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
