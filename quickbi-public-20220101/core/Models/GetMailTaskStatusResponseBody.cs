// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetMailTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38C0FEC8-****-415C-A9F1-****422BDB65</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetMailTaskStatusResponseBodyResult> Result { get; set; }
        public class GetMailTaskStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Execution time, in the format yyyy-MM-dd HH:mm:ss</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-09 17:34:11</para>
            /// </summary>
            [NameInMap("execTime")]
            [Validation(Required=false)]
            public string ExecTime { get; set; }

            /// <summary>
            /// <para>Mail ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>c38f73f4c5*****c808c41b3f4d23b7852</para>
            /// </summary>
            [NameInMap("mailId")]
            [Validation(Required=false)]
            public string MailId { get; set; }

            /// <summary>
            /// <para>Mail status. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>Success: SENT</description></item>
            /// <item><description>Failure: FAILED </description></item>
            /// <item><description>In Progress: PROCESSING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SENT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1282xxx610816</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful. </description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
