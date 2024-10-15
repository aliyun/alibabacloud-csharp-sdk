// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainExceedApplyQueryResponseBody : TeaModel {
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
        public TrainExceedApplyQueryResponseBodyModule Module { get; set; }
        public class TrainExceedApplyQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>apply1</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("apply_intention_info_d_o")]
            [Validation(Required=false)]
            public TrainExceedApplyQueryResponseBodyModuleApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
            public class TrainExceedApplyQueryResponseBodyModuleApplyIntentionInfoDO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-02-24T09:55Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_station")]
                [Validation(Required=false)]
                public string DepStation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-02-24T09:55Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("seat_name")]
                [Validation(Required=false)]
                public string SeatName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>G39</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                [NameInMap("train_type_desc")]
                [Validation(Required=false)]
                public string TrainTypeDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32</para>
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
            /// <para>32</para>
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
            /// <para>2022-02-24T09:55Z</para>
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
            /// <para>testcorp1</para>
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
        /// <para>BE3FBA15-C5E1-5B99-8120-9FB84A04FB81</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
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
