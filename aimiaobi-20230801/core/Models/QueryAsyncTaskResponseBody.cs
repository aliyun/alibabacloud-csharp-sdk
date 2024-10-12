// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class QueryAsyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAsyncTaskResponseBodyData Data { get; set; }
        public class QueryAsyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-07-25 14:34:33</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12121</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MaterialDocumentUpload</para>
            /// </summary>
            [NameInMap("TaskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("TaskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskIntermediateResult")]
            [Validation(Required=false)]
            public string TaskIntermediateResult { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;fileKey&quot;:&quot;oss://default/xxxx/xxxx/xxx&quot;,&quot;fileName&quot;:&quot;xxxxx.doc&quot;}</para>
            /// </summary>
            [NameInMap("TaskParam")]
            [Validation(Required=false)]
            public string TaskParam { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskProgressMessage")]
            [Validation(Required=false)]
            public string TaskProgressMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TaskRetryCount")]
            [Validation(Required=false)]
            public string TaskRetryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-27 18:07:43</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12121</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>867C4ABE-4381-5BC2-9810-5A5F334F71CF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
