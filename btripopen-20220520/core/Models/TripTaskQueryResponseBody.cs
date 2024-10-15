// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TripTaskQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("needRefresh")]
            [Validation(Required=false)]
            public bool? NeedRefresh { get; set; }

            [NameInMap("record_tasks")]
            [Validation(Required=false)]
            public List<TripTaskQueryResponseBodyModuleRecordTasks> RecordTasks { get; set; }
            public class TripTaskQueryResponseBodyModuleRecordTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("actioner")]
                [Validation(Required=false)]
                public string Actioner { get; set; }

                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1525104000</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1525104000</para>
                /// </summary>
                [NameInMap("gmt_finished")]
                [Validation(Required=false)]
                public long? GmtFinished { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>34360</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>575003</para>
                /// </summary>
                [NameInMap("node_id")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agree</para>
                /// </summary>
                [NameInMap("out_result")]
                [Validation(Required=false)]
                public string OutResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("running_tasks")]
            [Validation(Required=false)]
            public List<TripTaskQueryResponseBodyModuleRunningTasks> RunningTasks { get; set; }
            public class TripTaskQueryResponseBodyModuleRunningTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("actioner")]
                [Validation(Required=false)]
                public string Actioner { get; set; }

                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1525104000</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1525104000</para>
                /// </summary>
                [NameInMap("gmt_finished")]
                [Validation(Required=false)]
                public long? GmtFinished { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>34360</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>575003</para>
                /// </summary>
                [NameInMap("node_id")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agree</para>
                /// </summary>
                [NameInMap("out_result")]
                [Validation(Required=false)]
                public string OutResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FB0D7A8-BA41-5D04-BEFC-CADA5481AC53</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
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
