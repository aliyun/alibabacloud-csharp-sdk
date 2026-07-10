// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ConfirmPreBillResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the returned result.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public ConfirmPreBillResponseBodyModule Module { get; set; }
        public class ConfirmPreBillResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999</para>
            /// </summary>
            [NameInMap("batch_id")]
            [Validation(Required=false)]
            public long? BatchId { get; set; }

            /// <summary>
            /// <para>The number of bills that cannot be updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("forbid_update_bill_count")]
            [Validation(Required=false)]
            public int? ForbidUpdateBillCount { get; set; }

            /// <summary>
            /// <para>The details of items that cannot be updated.</para>
            /// </summary>
            [NameInMap("forbid_update_detail")]
            [Validation(Required=false)]
            public List<ConfirmPreBillResponseBodyModuleForbidUpdateDetail> ForbidUpdateDetail { get; set; }
            public class ConfirmPreBillResponseBodyModuleForbidUpdateDetail : TeaModel {
                /// <summary>
                /// <para>The number of items that cannot be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("can_not_update_count")]
                [Validation(Required=false)]
                public int? CanNotUpdateCount { get; set; }

                /// <summary>
                /// <para>The number of items that can be updated.</para>
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
                /// <para>[]</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of matched items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("match_count")]
            [Validation(Required=false)]
            public int? MatchCount { get; set; }

            /// <summary>
            /// <para>The number of unmatched items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("not_match_count")]
            [Validation(Required=false)]
            public int? NotMatchCount { get; set; }

            /// <summary>
            /// <para>The details of unmatched items.</para>
            /// </summary>
            [NameInMap("not_match_detail")]
            [Validation(Required=false)]
            public List<string> NotMatchDetail { get; set; }

        }

        /// <summary>
        /// <para>The pagination token set by the server. Indicates whether more data is available on the next page during pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
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
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
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
