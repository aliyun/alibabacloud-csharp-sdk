// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTaskDetailResponseBody : TeaModel {
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
        /// <para>The queried data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskDetailResponseBodyData Data { get; set; }
        public class QueryTaskDetailResponseBodyData : TeaModel {
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
            /// <para>The outbound task information.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryTaskDetailResponseBodyDataList> List { get; set; }
            public class QueryTaskDetailResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The caller number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1367123xxxx</para>
                /// </summary>
                [NameInMap("Ani")]
                [Validation(Required=false)]
                public string Ani { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BuId")]
                [Validation(Required=false)]
                public long? BuId { get; set; }

                /// <summary>
                /// <para>The department ID of the skill group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("DepartmentId")]
                [Validation(Required=false)]
                public long? DepartmentId { get; set; }

                /// <summary>
                /// <para>The called number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571456****</para>
                /// </summary>
                [NameInMap("Dnis")]
                [Validation(Required=false)]
                public string Dnis { get; set; }

                /// <summary>
                /// <para>The call end reasons.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110</para>
                /// </summary>
                [NameInMap("EndReason")]
                [Validation(Required=false)]
                public int? EndReason { get; set; }

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
                /// <para>The time when the task was created. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615445263000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the task was updated. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615478401000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The ID of the member. The ID of an anonymous member is -1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public long? MemberId { get; set; }

                /// <summary>
                /// <para>The name of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Anonymous member</para>
                /// </summary>
                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <para>The outbound call number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>130****0000</para>
                /// </summary>
                [NameInMap("OutboundNum")]
                [Validation(Required=false)]
                public int? OutboundNum { get; set; }

                /// <summary>
                /// <para>The ID of the outbound task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120001</para>
                /// </summary>
                [NameInMap("OutboundTaskId")]
                [Validation(Required=false)]
                public long? OutboundTaskId { get; set; }

                /// <summary>
                /// <para>The priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The next retry time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RetryTime")]
                [Validation(Required=false)]
                public string RetryTime { get; set; }

                /// <summary>
                /// <para>The ID of the customer service representative.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1212</para>
                /// </summary>
                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public long? ServicerId { get; set; }

                /// <summary>
                /// <para>The name of the customer service representative.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <para>The ID of the skill group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("SkillGroup")]
                [Validation(Required=false)]
                public int? SkillGroup { get; set; }

                /// <summary>
                /// <para>The outbound call status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Inbound call ringing.</description></item>
                /// <item><description><b>2</b>: Inbound call answered.</description></item>
                /// <item><description><b>3</b>: Inbound call disconnected.</description></item>
                /// <item><description><b>4</b>: Outbound call ringing.</description></item>
                /// <item><description><b>5</b>: Outbound call answered.</description></item>
                /// <item><description><b>6</b>: Outbound call disconnected.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34</para>
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
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
