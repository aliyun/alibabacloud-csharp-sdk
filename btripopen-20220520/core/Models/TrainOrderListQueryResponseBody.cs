// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderListQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<TrainOrderListQueryResponseBodyModule> Module { get; set; }
        public class TrainOrderListQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The business travel approval ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11367</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            /// <summary>
            /// <para>The arrival city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            /// <summary>
            /// <para>The arrival city code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("arr_city_ad_code")]
            [Validation(Required=false)]
            public string ArrCityAdCode { get; set; }

            /// <summary>
            /// <para>The arrival station.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州东站</para>
            /// </summary>
            [NameInMap("arr_station")]
            [Validation(Required=false)]
            public string ArrStation { get; set; }

            /// <summary>
            /// <para>The arrival date.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("arr_time")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>出差</para>
            /// </summary>
            [NameInMap("btrip_title")]
            [Validation(Required=false)]
            public string BtripTitle { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>商旅企业id</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The enterprise name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里巴巴</para>
            /// </summary>
            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>The cost center information.</para>
            /// </summary>
            [NameInMap("cost_center")]
            [Validation(Required=false)]
            public TrainOrderListQueryResponseBodyModuleCostCenter CostCenter { get; set; }
            public class TrainOrderListQueryResponseBodyModuleCostCenter : TeaModel {
                /// <summary>
                /// <para>The business travel enterprise ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅企业id</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The business travel cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11643</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试成本中心</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The cost center number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS112234</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public string Number { get; set; }

            }

            /// <summary>
            /// <para>The departure city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            /// <summary>
            /// <para>The departure city code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("dep_city_ad_code")]
            [Validation(Required=false)]
            public string DepCityAdCode { get; set; }

            /// <summary>
            /// <para>The departure station.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京西站</para>
            /// </summary>
            [NameInMap("dep_station")]
            [Validation(Required=false)]
            public string DepStation { get; set; }

            /// <summary>
            /// <para>The departure date.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// <para>The department ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>用户所在部门id</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            /// <summary>
            /// <para>The department name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>部门名称</para>
            /// </summary>
            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15T22:27Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The train ticket order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1478652</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The invoice information.</para>
            /// </summary>
            [NameInMap("invoice")]
            [Validation(Required=false)]
            public TrainOrderListQueryResponseBodyModuleInvoice Invoice { get; set; }
            public class TrainOrderListQueryResponseBodyModuleInvoice : TeaModel {
                /// <summary>
                /// <para>The business travel invoice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11324</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里巴巴</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The price information list.</para>
            /// </summary>
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<TrainOrderListQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class TrainOrderListQueryResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <para>The transaction category code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <para>The transaction category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("end_city")]
                [Validation(Required=false)]
                public string EndCity { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The transaction creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The original train number before rescheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS-663</para>
                /// </summary>
                [NameInMap("original_train_no")]
                [Validation(Required=false)]
                public string OriginalTrainNo { get; set; }

                /// <summary>
                /// <para>The passenger names, separated by \&quot;/\&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三/李四</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The settlement method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <para>The seat class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>软卧</para>
                /// </summary>
                [NameInMap("seat_type")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("start_city")]
                [Validation(Required=false)]
                public string StartCity { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-15T22:27Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The order transaction serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs1165734212</para>
                /// </summary>
                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <para>The train number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Z1521</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                /// <summary>
                /// <para>The fund flow direction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The project code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PCXIDF</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12425</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试项目</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The passenger name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("rider_name")]
            [Validation(Required=false)]
            public string RiderName { get; set; }

            /// <summary>
            /// <para>The travel duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("run_time")]
            [Validation(Required=false)]
            public string RunTime { get; set; }

            /// <summary>
            /// <para>The seat class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>一等座</para>
            /// </summary>
            [NameInMap("seat_type")]
            [Validation(Required=false)]
            public string SeatType { get; set; }

            /// <summary>
            /// <para>The order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The external approval ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00021230711000001Test-2</para>
            /// </summary>
            [NameInMap("thirdPart_business_id")]
            [Validation(Required=false)]
            public string ThirdPartBusinessId { get; set; }

            /// <summary>
            /// <para>The third-party project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-SKPFDS</para>
            /// </summary>
            [NameInMap("third_part_project_id")]
            [Validation(Required=false)]
            public string ThirdPartProjectId { get; set; }

            /// <summary>
            /// <para>The third-party application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSIODJUSN</para>
            /// </summary>
            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            /// <summary>
            /// <para>The third-party itinerary ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-IT89D</para>
            /// </summary>
            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

            /// <summary>
            /// <para>The number of tickets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ticket_count")]
            [Validation(Required=false)]
            public int? TicketCount { get; set; }

            /// <summary>
            /// <para>The 12306 ticket number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-663</para>
            /// </summary>
            [NameInMap("ticket_no12306")]
            [Validation(Required=false)]
            public string TicketNo12306 { get; set; }

            /// <summary>
            /// <para>The train number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-663</para>
            /// </summary>
            [NameInMap("train_number")]
            [Validation(Required=false)]
            public string TrainNumber { get; set; }

            /// <summary>
            /// <para>The train type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>高铁</para>
            /// </summary>
            [NameInMap("train_type")]
            [Validation(Required=false)]
            public string TrainType { get; set; }

            /// <summary>
            /// <para>The list of traveler information.</para>
            /// </summary>
            [NameInMap("user_affiliate_list")]
            [Validation(Required=false)]
            public List<TrainOrderListQueryResponseBodyModuleUserAffiliateList> UserAffiliateList { get; set; }
            public class TrainOrderListQueryResponseBodyModuleUserAffiliateList : TeaModel {
                /// <summary>
                /// <para>The passenger ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>乘车人id</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The passenger name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The third-party user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>第三方用户id</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public TrainOrderListQueryResponseBodyPageInfo PageInfo { get; set; }
        public class TrainOrderListQueryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F93C3EBD-17BE-5FE6-BF06-96A6F1AC8DC5</para>
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
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
