// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GenerateDISyncTaskConfigForCreatingResponseBody : TeaModel {
        /// <summary>
        /// <para>The generation result of the asynchronous thread ID.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateDISyncTaskConfigForCreatingResponseBodyData Data { get; set; }
        public class GenerateDISyncTaskConfigForCreatingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the cause for the failure to generate the asynchronous thread ID.
            /// If the asynchronous thread ID is generated, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX is invalid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The asynchronous thread ID. You must use this ID to call the <a href="https://help.aliyun.com/document_detail/383465.html">QueryDISyncTaskConfigProcessResult</a> operation to obtain the parameters required for asynchronously generating the configuration of the Data Integration synchronization task, and then use the parameters to create the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// <para>The status of generating the asynchronous thread ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The asynchronous thread ID is generated.</description></item>
            /// <item><description>fail: The asynchronous thread ID fails to be generated. You can view the cause of the failure and troubleshoot the issue.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
