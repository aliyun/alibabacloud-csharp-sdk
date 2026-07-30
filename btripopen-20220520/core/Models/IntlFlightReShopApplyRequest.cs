// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopApplyRequest : TeaModel {
        /// <summary>
        /// <para>The asynchronous application key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asyncKey_2390u230slgw023</para>
        /// </summary>
        [NameInMap("async_apply_key")]
        [Validation(Required=false)]
        public string AsyncApplyKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the asynchronous commit pattern. If asynchronous commit is used, only a key is returned before the application result is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("async_apply_mode")]
        [Validation(Required=false)]
        public bool? AsyncApplyMode { get; set; }

        /// <summary>
        /// <para>The business travel order ID. Required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017035199907040165</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The external order ID. Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D1736316966048SC4877</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The external rebooking application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JPM20241024354</para>
        /// </summary>
        [NameInMap("out_re_shop_apply_id")]
        [Validation(Required=false)]
        public string OutReShopApplyId { get; set; }

        /// <summary>
        /// <para>The rebooking group key returned by the consultation API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edcac4f4c79d40ccb141ddb6da567e65</para>
        /// </summary>
        [NameInMap("passenger_journey_group_key")]
        [Validation(Required=false)]
        public string PassengerJourneyGroupKey { get; set; }

        /// <summary>
        /// <para>The rebooking reason code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("re_shop_reason_code")]
        [Validation(Required=false)]
        public string ReShopReasonCode { get; set; }

        /// <summary>
        /// <para>The list of journeys selected for rebooking (submit only the journeys that need to be rebooked).</para>
        /// <remarks>
        /// <para>Notice: 
        /// Submit by the journey dimension of the order (you can aggregate by journeyIndex). Segments must be placed under the corresponding journey. For one-way trips, there is only one journey. For round trips, the outbound and return journeys are separate. For multi-city trips, each journey is separate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("selected_journeys")]
        [Validation(Required=false)]
        public List<IntlFlightReShopApplyRequestSelectedJourneys> SelectedJourneys { get; set; }
        public class IntlFlightReShopApplyRequestSelectedJourneys : TeaModel {
            /// <summary>
            /// <para>The three-letter code of the arrival city.</para>
            /// <remarks>
            /// <para>Notice: Must be consistent with the three-letter code of the arrival city of the last segment.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DLC</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>The three-letter code of the departure city.</para>
            /// <remarks>
            /// <para>Notice: Must be consistent with the three-letter code of the departure city of the first segment.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TSN</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>The intended date selected by the user. Format: yyyy-MM-dd.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-10</para>
            /// </summary>
            [NameInMap("intent_date")]
            [Validation(Required=false)]
            public string IntentDate { get; set; }

            /// <summary>
            /// <para>The flight information selected for rebooking.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("selected_flights")]
            [Validation(Required=false)]
            public List<IntlFlightReShopApplyRequestSelectedJourneysSelectedFlights> SelectedFlights { get; set; }
            public class IntlFlightReShopApplyRequestSelectedJourneysSelectedFlights : TeaModel {
                /// <summary>
                /// <para>The arrival city code.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HKG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The unique key of the segment. Format: flight number + departure airport + arrival airport + departure date (MMdd).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KN6728HGHPKX0725</para>
                /// </summary>
                [NameInMap("segment_key")]
                [Validation(Required=false)]
                public string SegmentKey { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of passengers selected for rebooking.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("selected_passengers")]
        [Validation(Required=false)]
        public List<IntlFlightReShopApplyRequestSelectedPassengers> SelectedPassengers { get; set; }
        public class IntlFlightReShopApplyRequestSelectedPassengers : TeaModel {
            /// <summary>
            /// <para>The full name of the passenger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANG/SAN</para>
            /// </summary>
            [NameInMap("full_name")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            /// <summary>
            /// <para>The passenger ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public long? PassengerId { get; set; }

        }

        /// <summary>
        /// <para>The rebooking intention remarks submitted by the user, such as acceptable price range and preferred departure/arrival airports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>少中转优先,落地当地时间为白天优先</para>
        /// </summary>
        [NameInMap("user_intention_memo")]
        [Validation(Required=false)]
        public string UserIntentionMemo { get; set; }

    }

}
