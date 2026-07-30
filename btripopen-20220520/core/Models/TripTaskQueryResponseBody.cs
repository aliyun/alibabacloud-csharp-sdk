// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TripTaskQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module。</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TripTaskQueryResponseBodyModule Module { get; set; }
        public class TripTaskQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Indicates whether a retry is needed. Asynchronous scheduling may cause delayed task generation. If the value is true, retry loading the data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("needRefresh")]
            [Validation(Required=false)]
            public bool? NeedRefresh { get; set; }

            /// <summary>
            /// <para>The historical approval tasks.</para>
            /// </summary>
            [NameInMap("record_tasks")]
            [Validation(Required=false)]
            public List<TripTaskQueryResponseBodyModuleRecordTasks> RecordTasks { get; set; }
            public class TripTaskQueryResponseBodyModuleRecordTasks : TeaModel {
                /// <summary>
                /// <para>The actual task executor. Valid when the task status is COMPLETED or REDIRECTED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("actioner")]
                [Validation(Required=false)]
                public string Actioner { get; set; }

                /// <summary>
                /// <para>The extended fields. Example: {&quot;tripNodeId&quot;:&quot;type_xWxl&quot;,&quot;tripNodeName&quot;:&quot;Approver&quot;}.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;tripNodeId&quot;:&quot;type_xWxl&quot;,&quot;tripNodeName&quot;:&quot;审批人&quot;}</para>
                /// </summary>
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <para>The task creation timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1525104000</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The task completion timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1525104000</para>
                /// </summary>
                [NameInMap("gmt_finished")]
                [Validation(Required=false)]
                public long? GmtFinished { get; set; }

                /// <summary>
                /// <para>The primary key, which is the task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34360</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The process node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>575003</para>
                /// </summary>
                [NameInMap("node_id")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The task result. Valid when the task status is COMPLETED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agree</para>
                /// </summary>
                [NameInMap("out_result")]
                [Validation(Required=false)]
                public string OutResult { get; set; }

                /// <summary>
                /// <para>The task owner (intended executor).</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The currently running approval tasks.</para>
            /// </summary>
            [NameInMap("running_tasks")]
            [Validation(Required=false)]
            public List<TripTaskQueryResponseBodyModuleRunningTasks> RunningTasks { get; set; }
            public class TripTaskQueryResponseBodyModuleRunningTasks : TeaModel {
                /// <summary>
                /// <para>The actual task executor. Valid when the task status is COMPLETED or REDIRECTED. This field is ignored in running_tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("actioner")]
                [Validation(Required=false)]
                public string Actioner { get; set; }

                /// <summary>
                /// <para>The extended fields. Example: {&quot;tripNodeId&quot;:&quot;type_xWxl&quot;,&quot;tripNodeName&quot;:&quot;Approver&quot;}.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;tripNodeId&quot;:&quot;type_xWxl&quot;,&quot;tripNodeName&quot;:&quot;审批人&quot;}</para>
                /// </summary>
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <para>The task creation timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1525104000</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The task completion timestamp. This field is ignored in running_tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1525104000</para>
                /// </summary>
                [NameInMap("gmt_finished")]
                [Validation(Required=false)]
                public long? GmtFinished { get; set; }

                /// <summary>
                /// <para>The primary key, which is the task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34360</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The process node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>575003</para>
                /// </summary>
                [NameInMap("node_id")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The task result. This field is ignored in running_tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agree</para>
                /// </summary>
                [NameInMap("out_result")]
                [Validation(Required=false)]
                public string OutResult { get; set; }

                /// <summary>
                /// <para>The task owner (intended executor).</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FB0D7A8-BA41-5D04-BEFC-CADA5481AC53</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
