// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class PollTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PollTaskResultResponseBodyData Data { get; set; }
        public class PollTaskResultResponseBodyData : TeaModel {
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public List<PollTaskResultResponseBodyDataTaskDetail> TaskDetail { get; set; }
            public class PollTaskResultResponseBodyDataTaskDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-03-26 15:08:20</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>The operation is successful.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>S201817141000000</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15fee9d10d514bada66bd08c5723c583</para>
                /// </summary>
                [NameInMap("TaskDetailNo")]
                [Validation(Required=false)]
                public string TaskDetailNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>b95bc334-f7d8-4f39-8a62-4c4302a243d8</para>
                /// </summary>
                [NameInMap("TaskNo")]
                [Validation(Required=false)]
                public string TaskNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TaskResult")]
                [Validation(Required=false)]
                public string TaskResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EXECUTE_SUCCESS</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TaskStatusCode")]
                [Validation(Required=false)]
                public int? TaskStatusCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CHG_DNS</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                [NameInMap("TaskTypeDescription")]
                [Validation(Required=false)]
                public string TaskTypeDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TryCount")]
                [Validation(Required=false)]
                public int? TryCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-03-26 15:22:18</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E879DC07-38EE-4408-9F33-73B30CD965CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
