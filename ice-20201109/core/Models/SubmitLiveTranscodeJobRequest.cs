// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveTranscodeJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the transcoding job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The start mode of the transcoding job.</para>
        /// <list type="bullet">
        /// <item><description>0: The transcoding job immediately starts.</description></item>
        /// <item><description>1: The transcoding job starts at the scheduled time.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartMode")]
        [Validation(Required=false)]
        public int? StartMode { get; set; }

        /// <summary>
        /// <para>The information about the input stream.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public SubmitLiveTranscodeJobRequestStreamInput StreamInput { get; set; }
        public class SubmitLiveTranscodeJobRequestStreamInput : TeaModel {
            /// <summary>
            /// <para>The URL of the input stream.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://mydomain/app/stream1</para>
            /// </summary>
            [NameInMap("InputUrl")]
            [Validation(Required=false)]
            public string InputUrl { get; set; }

            /// <summary>
            /// <para>The type of the input stream. The value can only be rtmp.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The configuration of a timed transcoding job. This parameter is required if you set StartMode to 1.</para>
        /// </summary>
        [NameInMap("TimedConfig")]
        [Validation(Required=false)]
        public SubmitLiveTranscodeJobRequestTimedConfig TimedConfig { get; set; }
        public class SubmitLiveTranscodeJobRequestTimedConfig : TeaModel {
            /// <summary>
            /// <para>The stop time of the transcoding job. Note: The time span between the stop time and the current time cannot exceed seven days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T08:20:32Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the transcoding job. Note: The time span between the start time and the current time cannot exceed seven days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-21T00:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The information about the transcoding output.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TranscodeOutput")]
        [Validation(Required=false)]
        public SubmitLiveTranscodeJobRequestTranscodeOutput TranscodeOutput { get; set; }
        public class SubmitLiveTranscodeJobRequestTranscodeOutput : TeaModel {
            /// <summary>
            /// <para>The streaming domain name of ApsaraVideo Live.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mydomain</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The type of the output stream. A value of LiveCenter indicates that the URL of the output stream is generated based on the domain name of ApsaraVideo Live. The value can only be LiveCenter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LiveCenter</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
