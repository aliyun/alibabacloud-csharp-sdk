// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskDetailHistoryResponseBody : TeaModel {
        [NameInMap("CurrentPageCursor")]
        [Validation(Required=false)]
        public QueryTaskDetailHistoryResponseBodyCurrentPageCursor CurrentPageCursor { get; set; }
        public class QueryTaskDetailHistoryResponseBodyCurrentPageCursor : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
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

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S1234456789</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-2342</para>
            /// </summary>
            [NameInMap("TaskDetailNo")]
            [Validation(Required=false)]
            public string TaskDetailNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

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
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("NextPageCursor")]
        [Validation(Required=false)]
        public QueryTaskDetailHistoryResponseBodyNextPageCursor NextPageCursor { get; set; }
        public class QueryTaskDetailHistoryResponseBodyNextPageCursor : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
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

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S1234567890</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-2424</para>
            /// </summary>
            [NameInMap("TaskDetailNo")]
            [Validation(Required=false)]
            public string TaskDetailNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EXECUTE_FAILURE</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TryCount")]
            [Validation(Required=false)]
            public int? TryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("Objects")]
        [Validation(Required=false)]
        public List<QueryTaskDetailHistoryResponseBodyObjects> Objects { get; set; }
        public class QueryTaskDetailHistoryResponseBodyObjects : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
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

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S123456789</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-4234</para>
            /// </summary>
            [NameInMap("TaskDetailNo")]
            [Validation(Required=false)]
            public string TaskDetailNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EXECUTE_FAILURE</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TryCount")]
            [Validation(Required=false)]
            public int? TryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
        public QueryTaskDetailHistoryResponseBodyPrePageCursor PrePageCursor { get; set; }
        public class QueryTaskDetailHistoryResponseBodyPrePageCursor : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
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

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S123456789</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-123</para>
            /// </summary>
            [NameInMap("TaskDetailNo")]
            [Validation(Required=false)]
            public string TaskDetailNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>75addb07-28a3-450e-b5ec-test</para>
            /// </summary>
            [NameInMap("TaskNo")]
            [Validation(Required=false)]
            public string TaskNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EXECUTE_FAILURE</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TryCount")]
            [Validation(Required=false)]
            public int? TryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-07-30 00:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>548CAE74-88F8-402F-8C12-97E747389C51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
