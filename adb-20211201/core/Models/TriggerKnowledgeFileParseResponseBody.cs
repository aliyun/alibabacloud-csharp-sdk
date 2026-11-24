// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class TriggerKnowledgeFileParseResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TriggerKnowledgeFileParseResponseBodyData Data { get; set; }
        public class TriggerKnowledgeFileParseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the file submitted for reparsing, which is a decimal string. This parameter is returned only when the request is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The description of the operation result. If the operation fails, this parameter indicates the cause or the security error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reparse task submitted</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The status before submission. Valid values: PENDING, COMPLETED, FAILED, SKIPPED, and DUPLICATED. This parameter is returned only when the request is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("PreviousStatus")]
            [Validation(Required=false)]
            public string PreviousStatus { get; set; }

            /// <summary>
            /// <para>The status after submission. The value is fixed to PENDING. This parameter is returned only when the request is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public string ProcessStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation is successful. If the operation fails, the Data parameter contains only the Success and Message parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
