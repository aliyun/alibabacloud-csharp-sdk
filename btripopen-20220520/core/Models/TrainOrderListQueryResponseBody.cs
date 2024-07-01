// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderListQueryResponseBody : TeaModel {
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

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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

            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("invoice")]
            [Validation(Required=false)]
            public TrainOrderListQueryResponseBodyModuleInvoice Invoice { get; set; }
            public class TrainOrderListQueryResponseBodyModuleInvoice : TeaModel {
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
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                [NameInMap("end_city")]
                [Validation(Required=false)]
                public string EndCity { get; set; }

                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("original_train_no")]
                [Validation(Required=false)]
                public string OriginalTrainNo { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                [NameInMap("seat_type")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                [NameInMap("start_city")]
                [Validation(Required=false)]
                public string StartCity { get; set; }

                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            [NameInMap("rider_name")]
            [Validation(Required=false)]
            public string RiderName { get; set; }

            [NameInMap("run_time")]
            [Validation(Required=false)]
            public string RunTime { get; set; }

            [NameInMap("seat_type")]
            [Validation(Required=false)]
            public string SeatType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("thirdPart_business_id")]
            [Validation(Required=false)]
            public string ThirdPartBusinessId { get; set; }

            [NameInMap("third_part_project_id")]
            [Validation(Required=false)]
            public string ThirdPartProjectId { get; set; }

            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

            [NameInMap("ticket_count")]
            [Validation(Required=false)]
            public int? TicketCount { get; set; }

            [NameInMap("ticket_no12306")]
            [Validation(Required=false)]
            public string TicketNo12306 { get; set; }

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
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
