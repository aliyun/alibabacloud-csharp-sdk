// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLiveTranscodeJobRequest : TeaModel {
        /// <summary>
        /// <para>The job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytest3</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The information about the input stream.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public UpdateLiveTranscodeJobRequestStreamInput StreamInput { get; set; }
        public class UpdateLiveTranscodeJobRequestStreamInput : TeaModel {
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
        /// <para>The configuration of a timed transcoding job.</para>
        /// </summary>
        [NameInMap("TimedConfig")]
        [Validation(Required=false)]
        public UpdateLiveTranscodeJobRequestTimedConfig TimedConfig { get; set; }
        public class UpdateLiveTranscodeJobRequestTimedConfig : TeaModel {
            /// <summary>
            /// <para>The stop time of the transcoding job. Note: The time span between the stop time and the current time cannot exceed seven days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-05T06:08:31Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the transcoding job. Note: The time span between the start time and the current time cannot exceed seven days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-06-19T02:16:41Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The information about the transcoding output.</para>
        /// </summary>
        [NameInMap("TranscodeOutput")]
        [Validation(Required=false)]
        public UpdateLiveTranscodeJobRequestTranscodeOutput TranscodeOutput { get; set; }
        public class UpdateLiveTranscodeJobRequestTranscodeOutput : TeaModel {
            /// <summary>
            /// <para>The streaming domain name of ApsaraVideo Live.</para>
            /// <para>This parameter is required.</para>
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
