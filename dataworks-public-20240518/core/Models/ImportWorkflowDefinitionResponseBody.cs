// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ImportWorkflowDefinitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The asynchronous task status information.</para>
        /// </summary>
        [NameInMap("AsyncJob")]
        [Validation(Required=false)]
        public ImportWorkflowDefinitionResponseBodyAsyncJob AsyncJob { get; set; }
        public class ImportWorkflowDefinitionResponseBodyAsyncJob : TeaModel {
            /// <summary>
            /// <para>Indicates whether the asynchronous task is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            /// <summary>
            /// <para>The timestamp when the asynchronous task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706581425000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The error message returned when the asynchronous task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>target folder already exists: XXXX</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The ID of the asynchronous task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567691239009XXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The progress of the asynchronous task. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The content that the asynchronous task is expected to return.</para>
            /// <remarks>
            /// <para>This field currently contains the ID of the workflow created by the asynchronous task.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>632647691239009XXXX</para>
            /// </summary>
            [NameInMap("Response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            /// <summary>
            /// <para>The status of the asynchronous task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: The task is running.</description></item>
            /// <item><description>Success: The task succeeded.</description></item>
            /// <item><description>Fail: The task failed.</description></item>
            /// <item><description>Cancel: The task was canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The operation type of the asynchronous task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Create: creates a resource. </description></item>
            /// <item><description>Cancel: cancels a creation job.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Create</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C352CB7-CD88-50CF-9D0D-E81BDF020E7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
