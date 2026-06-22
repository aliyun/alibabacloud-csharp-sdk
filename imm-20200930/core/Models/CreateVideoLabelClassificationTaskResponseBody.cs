// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateVideoLabelClassificationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The event ID of the task. You can use this ID to query task information notifications in the <a href="https://www.aliyun.com/product/aliware/eventbridge">EventBridge</a> service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03F-1Qt1Yn5RZZ0Zh3ZdYlDblv7****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA995EFD-083D-4F40-BE8A-BDF75FFFE0B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the task. You can use the <a href="https://help.aliyun.com/document_detail/478241.html">GetTask</a> operation to view task information or the <a href="https://help.aliyun.com/document_detail/478224.html">GetVideoLabelClassificationResult</a> operation to obtain the results of the video label detection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VideoLabelClassification-2f157087-91df-4fda-8c3e-232407ec*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
