// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class BatchSubmitPreBillResponseBody : TeaModel {
        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public BatchSubmitPreBillResponseBodyModule Module { get; set; }
        public class BatchSubmitPreBillResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The batch ID. This value may be null if no actionable bills exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>999</para>
            /// </summary>
            [NameInMap("batch_id")]
            [Validation(Required=false)]
            public long? BatchId { get; set; }

            /// <summary>
            /// <para>The number of bills that cannot be updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("forbid_update_bill_count")]
            [Validation(Required=false)]
            public int? ForbidUpdateBillCount { get; set; }

            /// <summary>
            /// <para>The details of bills that cannot be updated.</para>
            /// </summary>
            [NameInMap("forbid_update_detail")]
            [Validation(Required=false)]
            public List<BatchSubmitPreBillResponseBodyModuleForbidUpdateDetail> ForbidUpdateDetail { get; set; }
            public class BatchSubmitPreBillResponseBodyModuleForbidUpdateDetail : TeaModel {
                /// <summary>
                /// <para>The number of records that cannot be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("can_not_update_count")]
                [Validation(Required=false)]
                public int? CanNotUpdateCount { get; set; }

                /// <summary>
                /// <para>The number of records that can be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("can_update_count")]
                [Validation(Required=false)]
                public int? CanUpdateCount { get; set; }

                /// <summary>
                /// <para>The value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;9999&quot;</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of matched records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("match_count")]
            [Validation(Required=false)]
            public int? MatchCount { get; set; }

            /// <summary>
            /// <para>The number of unmatched records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("not_match_count")]
            [Validation(Required=false)]
            public int? NotMatchCount { get; set; }

            /// <summary>
            /// <para>The unmatched details.</para>
            /// </summary>
            [NameInMap("not_match_detail")]
            [Validation(Required=false)]
            public List<string> NotMatchDetail { get; set; }

        }

        /// <summary>
        /// <para>The pagination token set by the server. Indicates whether more data exists on the next page during pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
