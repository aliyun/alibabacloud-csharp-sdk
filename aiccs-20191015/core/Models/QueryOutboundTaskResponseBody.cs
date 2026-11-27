// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryOutboundTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The outbound call task information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOutboundTaskResponseBodyData Data { get; set; }
        public class QueryOutboundTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public string CurrentPage { get; set; }

            /// <summary>
            /// <para>The list of outbound call records.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryOutboundTaskResponseBodyDataList> List { get; set; }
            public class QueryOutboundTaskResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BuId")]
                [Validation(Required=false)]
                public long? BuId { get; set; }

                /// <summary>
                /// <para>The caller number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>130****0000</para>
                /// </summary>
                [NameInMap("CallerNum")]
                [Validation(Required=false)]
                public string CallerNum { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("DepartmentId")]
                [Validation(Required=false)]
                public long? DepartmentId { get; set; }

                /// <summary>
                /// <para>The task description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The end date of task execution. The maximum time span between the start time and the end time is 7 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-08-09</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>The end time of task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The extended attributes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Note&quot;:&quot;Outbound call test&quot;}</para>
                /// </summary>
                [NameInMap("ExtAttrs")]
                [Validation(Required=false)]
                public string ExtAttrs { get; set; }

                /// <summary>
                /// <para>The task creation time. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615445263000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The task update time. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615478401000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The skill group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test skill group</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public int? Model { get; set; }

                /// <summary>
                /// <para>The modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test task</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The retry interval. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RetryInterval")]
                [Validation(Required=false)]
                public int? RetryInterval { get; set; }

                /// <summary>
                /// <para>The next retry time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RetryTime")]
                [Validation(Required=false)]
                public int? RetryTime { get; set; }

                /// <summary>
                /// <para>The skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19467</para>
                /// </summary>
                [NameInMap("SkillGroup")]
                [Validation(Required=false)]
                public long? SkillGroup { get; set; }

                /// <summary>
                /// <para>The start date of task execution. The maximum time span between the start time and the end time is 7 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-08-08</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                /// <summary>
                /// <para>The start time of task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09:09:09</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>194</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public string TotalResults { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
