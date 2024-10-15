// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderListQueryResponseBody : TeaModel {
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
        public List<TrainOrderListQueryResponseBodyModule> Module { get; set; }
        public class TrainOrderListQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>11367</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            [NameInMap("arr_city_ad_code")]
            [Validation(Required=false)]
            public string ArrCityAdCode { get; set; }

            [NameInMap("arr_station")]
            [Validation(Required=false)]
            public string ArrStation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("arr_time")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            [NameInMap("btrip_title")]
            [Validation(Required=false)]
            public string BtripTitle { get; set; }

            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            [NameInMap("cost_center")]
            [Validation(Required=false)]
            public TrainOrderListQueryResponseBodyModuleCostCenter CostCenter { get; set; }
            public class TrainOrderListQueryResponseBodyModuleCostCenter : TeaModel {
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11643</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS112234</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public string Number { get; set; }

            }

            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            [NameInMap("dep_city_ad_code")]
            [Validation(Required=false)]
            public string DepCityAdCode { get; set; }

            [NameInMap("dep_station")]
            [Validation(Required=false)]
            public string DepStation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1478652</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("invoice")]
            [Validation(Required=false)]
            public TrainOrderListQueryResponseBodyModuleInvoice Invoice { get; set; }
            public class TrainOrderListQueryResponseBodyModuleInvoice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>11324</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderListQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class TrainOrderListQueryResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                [NameInMap("end_city")]
                [Validation(Required=false)]
                public string EndCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-663</para>
                /// </summary>
                [NameInMap("original_train_no")]
                [Validation(Required=false)]
                public string OriginalTrainNo { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                [NameInMap("seat_type")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                [NameInMap("start_city")]
                [Validation(Required=false)]
                public string StartCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cs1165734212</para>
                /// </summary>
                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Z1521</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PCXIDF</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12425</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            [NameInMap("rider_name")]
            [Validation(Required=false)]
            public string RiderName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("run_time")]
            [Validation(Required=false)]
            public string RunTime { get; set; }

            [NameInMap("seat_type")]
            [Validation(Required=false)]
            public string SeatType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("thirdPart_business_id")]
            [Validation(Required=false)]
            public string ThirdPartBusinessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-SKPFDS</para>
            /// </summary>
            [NameInMap("third_part_project_id")]
            [Validation(Required=false)]
            public string ThirdPartProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CSIODJUSN</para>
            /// </summary>
            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-IT89D</para>
            /// </summary>
            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ticket_count")]
            [Validation(Required=false)]
            public int? TicketCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-663</para>
            /// </summary>
            [NameInMap("ticket_no12306")]
            [Validation(Required=false)]
            public string TicketNo12306 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-663</para>
            /// </summary>
            [NameInMap("train_number")]
            [Validation(Required=false)]
            public string TrainNumber { get; set; }

            [NameInMap("train_type")]
            [Validation(Required=false)]
            public string TrainType { get; set; }

            [NameInMap("user_affiliate_list")]
            [Validation(Required=false)]
            public List<TrainOrderListQueryResponseBodyModuleUserAffiliateList> UserAffiliateList { get; set; }
            public class TrainOrderListQueryResponseBodyModuleUserAffiliateList : TeaModel {
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("page_info")]
        [Validation(Required=false)]
        public TrainOrderListQueryResponseBodyPageInfo PageInfo { get; set; }
        public class TrainOrderListQueryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F93C3EBD-17BE-5FE6-BF06-96A6F1AC8DC5</para>
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
