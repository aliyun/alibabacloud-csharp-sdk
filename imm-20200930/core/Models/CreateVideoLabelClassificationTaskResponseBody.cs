// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateVideoLabelClassificationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The event ID of the current task. You can use <a href="https://www.alibabacloud.com/en/product/eventbridge">EventBridge</a> to query the ID and obtain the task information notification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03F-1Qt1Yn5RZZ0Zh3ZdYlDblv7****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA995EFD-083D-4F40-BE8A-BDF75FFFE0B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the current task. You can call the <a href="~~GetTask~~">GetTask</a> operation to view the task information or the <a href="https://help.aliyun.com/document_detail/478224.html">GetVideoLabelClassificationResult</a> operation to obtain the result of the video label detection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VideoLabelClassification-2f157087-91df-4fda-8c3e-232407ec*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
