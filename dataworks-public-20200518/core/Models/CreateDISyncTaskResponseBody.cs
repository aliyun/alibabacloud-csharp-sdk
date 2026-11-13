// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of creating the Data Integration synchronization task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDISyncTaskResponseBodyData Data { get; set; }
        public class CreateDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the successfully created Data Integration synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000001</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The description of the cause of the failure to create the Data Integration synchronization task. If the task is created, this field is empty. If the task fails to be created, an example value is &quot;Invalid directory path: Workflow/xxxx/Data Integration&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Invalid directory path: Workflow/xxxx/Data Integration</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The status of the result of creating the Data Integration synchronization task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The task is created.</description></item>
            /// <item><description>fail: The task fails to be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
