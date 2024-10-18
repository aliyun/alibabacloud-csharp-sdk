// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryOrgTodoTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("todoCards")]
        [Validation(Required=false)]
        public List<QueryOrgTodoTasksResponseBodyTodoCards> TodoCards { get; set; }
        public class QueryOrgTodoTasksResponseBodyTodoCards : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>isv_dingtalkTodo</para>
            /// </summary>
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1617675000000</para>
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl DetailUrl { get; set; }
            public class QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
                /// </summary>
                [NameInMap("appUrl")]
                [Validation(Required=false)]
                public string AppUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
                /// </summary>
                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1617675000000</para>
            /// </summary>
            [NameInMap("dueTime")]
            [Validation(Required=false)]
            public long? DueTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1617675000000</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>isv_dingtalkTodo1</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>接入钉钉待办</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>taskOPJpwtwPVNGIFKURjrzd</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
