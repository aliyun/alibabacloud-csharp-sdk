// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitTranscodeJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4EBD2BF-5EB0-4476-8829-9D94E1B1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the transcoding job.</para>
        /// <remarks>
        /// <para> This parameter is not returned for HLS packaging tasks. You must asynchronously receive the transcoding result.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TranscodeJobs")]
        [Validation(Required=false)]
        public SubmitTranscodeJobsResponseBodyTranscodeJobs TranscodeJobs { get; set; }
        public class SubmitTranscodeJobsResponseBodyTranscodeJobs : TeaModel {
            [NameInMap("TranscodeJob")]
            [Validation(Required=false)]
            public List<SubmitTranscodeJobsResponseBodyTranscodeJobsTranscodeJob> TranscodeJob { get; set; }
            public class SubmitTranscodeJobsResponseBodyTranscodeJobsTranscodeJob : TeaModel {
                /// <summary>
                /// <para>The ID of the transcoding job.</para>
                /// <remarks>
                /// <para> This parameter is not returned for HLS packaging tasks. You must asynchronously receive the transcoding result.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>d8921ce8505716cfe86fb112c4****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the transcoding task that was submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9f4a0df7da2c8a81c8c0408c84****</para>
        /// </summary>
        [NameInMap("TranscodeTaskId")]
        [Validation(Required=false)]
        public string TranscodeTaskId { get; set; }

    }

}
