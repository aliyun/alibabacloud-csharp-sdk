// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSimilarSecurityEventsQueryTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the task that queries alert events of the same alert type.</para>
        /// </summary>
        [NameInMap("CreateSimilarSecurityEventsQueryTaskResponse")]
        [Validation(Required=false)]
        public CreateSimilarSecurityEventsQueryTaskResponseBodyCreateSimilarSecurityEventsQueryTaskResponse CreateSimilarSecurityEventsQueryTaskResponse { get; set; }
        public class CreateSimilarSecurityEventsQueryTaskResponseBodyCreateSimilarSecurityEventsQueryTaskResponse : TeaModel {
            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>New</b>: The task is created.</description></item>
            /// <item><description><b>RetrievingData</b>: Data is being retrieved.</description></item>
            /// <item><description><b>DataRetrieved</b>: Data is retrieved.</description></item>
            /// <item><description><b>Processing</b>: The task is running.</description></item>
            /// <item><description><b>Success</b>: The task is successful.</description></item>
            /// <item><description><b>Failed</b>: The task failed.</description></item>
            /// <item><description><b>PartialFailed</b>: The task partially failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>New</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2915</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5861EE3E-F0B3-48B8-A5DC-A5080BFBE052</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
