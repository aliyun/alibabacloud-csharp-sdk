// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelExceedApplyQueryResponseBody : TeaModel {
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

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelExceedApplyQueryResponseBodyModule Module { get; set; }
        public class HotelExceedApplyQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>27238197</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("apply_intention_info_do")]
            [Validation(Required=false)]
            public HotelExceedApplyQueryResponseBodyModuleApplyIntentionInfoDo ApplyIntentionInfoDo { get; set; }
            public class HotelExceedApplyQueryResponseBodyModuleApplyIntentionInfoDo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-07-08</para>
                /// </summary>
                [NameInMap("check_in")]
                [Validation(Required=false)]
                public string CheckIn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-07-08</para>
                /// </summary>
                [NameInMap("check_out")]
                [Validation(Required=false)]
                public string CheckOut { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("together")]
                [Validation(Required=false)]
                public bool? Together { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("btrip_cause")]
            [Validation(Required=false)]
            public string BtripCause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>corp1</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("exceed_reason")]
            [Validation(Required=false)]
            public string ExceedReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("exceed_type")]
            [Validation(Required=false)]
            public int? ExceedType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("origin_standard")]
            [Validation(Required=false)]
            public string OriginStandard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-02-11T16:25Z</para>
            /// </summary>
            [NameInMap("submit_time")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0001A1100000007EX08O</para>
            /// </summary>
            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_corp</para>
            /// </summary>
            [NameInMap("thirdpart_corp_id")]
            [Validation(Required=false)]
            public string ThirdpartCorpId { get; set; }

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
        /// <para>E03779E6-71C2-5082-ABE3-6315B8247EE8</para>
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
