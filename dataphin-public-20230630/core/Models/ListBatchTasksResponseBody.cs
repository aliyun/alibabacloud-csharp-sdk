// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListBatchTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paginated result of the task query.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListBatchTasksResponseBodyPageResult PageResult { get; set; }
        public class ListBatchTasksResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The total number of tasks that meet the query conditions, regardless of pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of tasks on the current page.</para>
            /// </summary>
            [NameInMap("ResultData")]
            [Validation(Required=false)]
            public List<ListBatchTasksResponseBodyPageResultResultData> ResultData { get; set; }
            public class ListBatchTasksResponseBodyPageResultResultData : TeaModel {
                /// <summary>
                /// <para>The description of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Order detail processing task</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The folder where the task is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dwd</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The ID of the task file. You can use this ID as the input parameter for the GetBatchTaskInfo operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7090125821589888</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The latest submit status. Valid values: SUBMITTING, SUCCESS, and FAILED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("LastSubmitStatus")]
                [Validation(Required=false)]
                public string LastSubmitStatus { get; set; }

                /// <summary>
                /// <para>The latest submitted version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("LastVersion")]
                [Validation(Required=false)]
                public int? LastVersion { get; set; }

                /// <summary>
                /// <para>The name of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dwd_order_detail</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123456</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dwd_order_detail</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The list of output table names for the node.</para>
                /// </summary>
                [NameInMap("NodeOutputNameList")]
                [Validation(Required=false)]
                public List<string> NodeOutputNameList { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values: 1 (periodic task) and 3 (manual task).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

                /// <summary>
                /// <para>The task type code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OperatorType")]
                [Validation(Required=false)]
                public int? OperatorType { get; set; }

                /// <summary>
                /// <para>The name of the task owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The ID of the task owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30001011</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                /// <summary>
                /// <para>Indicates whether the task has been published to the production environment.</para>
                /// </summary>
                [NameInMap("Published")]
                [Validation(Required=false)]
                public bool? Published { get; set; }

                /// <summary>
                /// <para>Indicates whether the task has been submitted.</para>
                /// </summary>
                [NameInMap("Released")]
                [Validation(Required=false)]
                public bool? Released { get; set; }

                /// <summary>
                /// <para>The status of the task. Valid values: DRAFT, DEVELOP, and SUBMITTED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUBMITTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
