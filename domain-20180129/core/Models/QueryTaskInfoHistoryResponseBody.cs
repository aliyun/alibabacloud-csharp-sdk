// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskInfoHistoryResponseBody : TeaModel {
        [NameInMap("CurrentPageCursor")]
        [Validation(Required=false)]
        public QueryTaskInfoHistoryResponseBodyCurrentPageCursor CurrentPageCursor { get; set; }
        public class QueryTaskInfoHistoryResponseBodyCurrentPageCursor : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-11-01 17:22:51</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1509528171000</para>
            /// </summary>
            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aa634d3f-927e-4d17-9d2c-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
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

        }

        [NameInMap("NextPageCursor")]
        [Validation(Required=false)]
        public QueryTaskInfoHistoryResponseBodyNextPageCursor NextPageCursor { get; set; }
        public class QueryTaskInfoHistoryResponseBodyNextPageCursor : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-10-27 13:07:07</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1509080827000</para>
            /// </summary>
            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8f112aa1-98be-48c3-82f8-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
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

        }

        [NameInMap("Objects")]
        [Validation(Required=false)]
        public List<QueryTaskInfoHistoryResponseBodyObjects> Objects { get; set; }
        public class QueryTaskInfoHistoryResponseBodyObjects : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-11-01 17:22:51</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1509528171000</para>
            /// </summary>
            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aa634d3f-927e-4d17-9d2c-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePageCursor")]
        [Validation(Required=false)]
        public QueryTaskInfoHistoryResponseBodyPrePageCursor PrePageCursor { get; set; }
        public class QueryTaskInfoHistoryResponseBodyPrePageCursor : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-11-01 17:19:47</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1509527987000</para>
            /// </summary>
            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f9baa3d5-33b9-4c81-8847-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EB3FCCBA-CA1F-4D31-9F34-test</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
