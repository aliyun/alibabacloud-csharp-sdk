// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskDetailListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskDetailListResponseBodyData Data { get; set; }
        public class QueryTaskDetailListResponseBodyData : TeaModel {
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public List<QueryTaskDetailListResponseBodyDataTaskDetail> TaskDetail { get; set; }
            public class QueryTaskDetailListResponseBodyDataTaskDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-01-25 20:46:57</para>
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

                [NameInMap("FailReason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>S20179H1BBI9test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>75addb07-28a3-450e-b5ec-test</para>
                /// </summary>
                [NameInMap("TaskDetailNo")]
                [Validation(Required=false)]
                public string TaskDetailNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60d6e201-8ee5-47ab-8fdc-test</para>
                /// </summary>
                [NameInMap("TaskNo")]
                [Validation(Required=false)]
                public string TaskNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
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
                /// <para>ORDER_RENEW</para>
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
                /// <para>2018-01-25 20:47:01</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
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
        /// <para>6A2320E4-D870-49C9-A6DC-test</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
