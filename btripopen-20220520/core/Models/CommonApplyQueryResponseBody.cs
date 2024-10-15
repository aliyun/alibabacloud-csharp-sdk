// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CommonApplyQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public CommonApplyQueryResponseBodyModule Module { get; set; }
        public class CommonApplyQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("biz_category")]
            [Validation(Required=false)]
            public int? BizCategory { get; set; }

            [NameInMap("cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0001A1100000007EX08O</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("extend_value")]
            [Validation(Required=false)]
            public string ExtendValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-18T20:26Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1233</para>
            /// </summary>
            [NameInMap("thirdpart_corp_id")]
            [Validation(Required=false)]
            public string ThirdpartCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12344</para>
            /// </summary>
            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            [NameInMap("trip_cause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
