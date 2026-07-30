// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoListSearchResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainNoListSearchResponseBodyModule Module { get; set; }
        public class TrainNoListSearchResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The direct train search results.</para>
            /// </summary>
            [NameInMap("train_station_search_v_o_s")]
            [Validation(Required=false)]
            public List<TrainNoListSearchResponseBodyModuleTrainStationSearchVOS> TrainStationSearchVOS { get; set; }
            public class TrainNoListSearchResponseBodyModuleTrainStationSearchVOS : TeaModel {
                /// <summary>
                /// <para>The number of days crossed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("arr_day_tag")]
                [Validation(Required=false)]
                public string ArrDayTag { get; set; }

                /// <summary>
                /// <para>The arrival station code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BDC</para>
                /// </summary>
                [NameInMap("arr_station_code")]
                [Validation(Required=false)]
                public string ArrStationCode { get; set; }

                /// <summary>
                /// <para>The arrival station name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>包头东</para>
                /// </summary>
                [NameInMap("arr_station_name")]
                [Validation(Required=false)]
                public string ArrStationName { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-07 14:46:06</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The travel duration. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("cost_time")]
                [Validation(Required=false)]
                public string CostTime { get; set; }

                /// <summary>
                /// <para>The departure station code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BTC</para>
                /// </summary>
                [NameInMap("dep_station_code")]
                [Validation(Required=false)]
                public string DepStationCode { get; set; }

                /// <summary>
                /// <para>The departure station name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>包头</para>
                /// </summary>
                [NameInMap("dep_station_name")]
                [Validation(Required=false)]
                public string DepStationName { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-06 14:46:06</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the station is the terminal station. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Yes.</description></item>
                /// <item><description>0: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("is_end_station")]
                [Validation(Required=false)]
                public int? IsEndStation { get; set; }

                /// <summary>
                /// <para>Indicates whether the station is the originating station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("is_start_station")]
                [Validation(Required=false)]
                public int? IsStartStation { get; set; }

                /// <summary>
                /// <para>The price. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>54000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                /// <summary>
                /// <para>Indicates whether the train is available for booking. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Available.</description></item>
                /// <item><description>0: Not available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sale_flag")]
                [Validation(Required=false)]
                public string SaleFlag { get; set; }

                /// <summary>
                /// <para>The reason why the train is unavailable for booking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>没有原因</para>
                /// </summary>
                [NameInMap("sale_flag_msg")]
                [Validation(Required=false)]
                public string SaleFlagMsg { get; set; }

                /// <summary>
                /// <para>The segment index of the trip.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("seagment_index")]
                [Validation(Required=false)]
                public string SeagmentIndex { get; set; }

                /// <summary>
                /// <para>The seat information.</para>
                /// </summary>
                [NameInMap("seat_infos")]
                [Validation(Required=false)]
                public List<TrainNoListSearchResponseBodyModuleTrainStationSearchVOSSeatInfos> SeatInfos { get; set; }
                public class TrainNoListSearchResponseBodyModuleTrainStationSearchVOSSeatInfos : TeaModel {
                    /// <summary>
                    /// <para>The price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40900</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    /// <summary>
                    /// <para>The seat name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>二等座</para>
                    /// </summary>
                    [NameInMap("seat_name")]
                    [Validation(Required=false)]
                    public string SeatName { get; set; }

                    /// <summary>
                    /// <para>The seat type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("seat_type")]
                    [Validation(Required=false)]
                    public string SeatType { get; set; }

                    /// <summary>
                    /// <para>The remaining ticket availability. If the remaining quantity is 0, the value is &quot;None&quot;. If the remaining quantity is greater than 99, the value is &quot;Available&quot;. If the remaining quantity is between 1 and 99, the specific number is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>有</para>
                    /// </summary>
                    [NameInMap("stock")]
                    [Validation(Required=false)]
                    public string Stock { get; set; }

                }

                /// <summary>
                /// <para>The train number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>D2345</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                /// <summary>
                /// <para>The train type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("train_type")]
                [Validation(Required=false)]
                public string TrainType { get; set; }

            }

            /// <summary>
            /// <para>The transfer train search results.</para>
            /// </summary>
            [NameInMap("train_transfer_station_search_v_os")]
            [Validation(Required=false)]
            public List<TrainNoListSearchResponseBodyModuleTrainTransferStationSearchVOs> TrainTransferStationSearchVOs { get; set; }
            public class TrainNoListSearchResponseBodyModuleTrainTransferStationSearchVOs : TeaModel {
                /// <summary>
                /// <para>The arrival station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>重庆西</para>
                /// </summary>
                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                /// <summary>
                /// <para>The departure station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>巫山站</para>
                /// </summary>
                [NameInMap("dep_station")]
                [Validation(Required=false)]
                public string DepStation { get; set; }

                /// <summary>
                /// <para>The unique route identifier. This is required for transfer routes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中转唯一标识</para>
                /// </summary>
                [NameInMap("line_key")]
                [Validation(Required=false)]
                public string LineKey { get; set; }

                /// <summary>
                /// <para>The transfer station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>万州北</para>
                /// </summary>
                [NameInMap("middle_station")]
                [Validation(Required=false)]
                public string MiddleStation { get; set; }

                /// <summary>
                /// <para>The list of transfer trains.</para>
                /// </summary>
                [NameInMap("transfer_detail_list")]
                [Validation(Required=false)]
                public List<TrainNoListSearchResponseBodyModuleTrainTransferStationSearchVOsTransferDetailList> TransferDetailList { get; set; }
                public class TrainNoListSearchResponseBodyModuleTrainTransferStationSearchVOsTransferDetailList : TeaModel {
                    /// <summary>
                    /// <para>The number of days crossed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("arr_day_tag")]
                    [Validation(Required=false)]
                    public string ArrDayTag { get; set; }

                    /// <summary>
                    /// <para>The arrival station code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123344</para>
                    /// </summary>
                    [NameInMap("arr_station_code")]
                    [Validation(Required=false)]
                    public string ArrStationCode { get; set; }

                    /// <summary>
                    /// <para>The arrival station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>巫山站</para>
                    /// </summary>
                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-07 14:46:06</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The travel duration. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>234567</para>
                    /// </summary>
                    [NameInMap("cost_time")]
                    [Validation(Required=false)]
                    public string CostTime { get; set; }

                    /// <summary>
                    /// <para>The departure station code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12334</para>
                    /// </summary>
                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    /// <summary>
                    /// <para>The departure station name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>重庆西</para>
                    /// </summary>
                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-06 14:46:06</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the station is the terminal station. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: Yes.</description></item>
                    /// <item><description>0: No.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("is_end_station")]
                    [Validation(Required=false)]
                    public int? IsEndStation { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the station is the originating station. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: Yes.</description></item>
                    /// <item><description>0: No.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("is_start_station")]
                    [Validation(Required=false)]
                    public int? IsStartStation { get; set; }

                    /// <summary>
                    /// <para>The price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>105000</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the train is available for booking. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: Available.</description></item>
                    /// <item><description>0: Not available.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sale_flag")]
                    [Validation(Required=false)]
                    public string SaleFlag { get; set; }

                    /// <summary>
                    /// <para>The reason why the train is unavailable for booking.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>没有原因</para>
                    /// </summary>
                    [NameInMap("sale_flag_msg")]
                    [Validation(Required=false)]
                    public string SaleFlagMsg { get; set; }

                    /// <summary>
                    /// <para>The seat information.</para>
                    /// </summary>
                    [NameInMap("seat_infos")]
                    [Validation(Required=false)]
                    public List<TrainNoListSearchResponseBodyModuleTrainTransferStationSearchVOsTransferDetailListSeatInfos> SeatInfos { get; set; }
                    public class TrainNoListSearchResponseBodyModuleTrainTransferStationSearchVOsTransferDetailListSeatInfos : TeaModel {
                        /// <summary>
                        /// <para>The price. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>40900</para>
                        /// </summary>
                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public long? Price { get; set; }

                        /// <summary>
                        /// <para>The seat name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>二等座</para>
                        /// </summary>
                        [NameInMap("seat_name")]
                        [Validation(Required=false)]
                        public string SeatName { get; set; }

                        /// <summary>
                        /// <para>The seat type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>14</para>
                        /// </summary>
                        [NameInMap("seat_type")]
                        [Validation(Required=false)]
                        public string SeatType { get; set; }

                        /// <summary>
                        /// <para>The remaining ticket availability. If the remaining quantity is 0, the value is &quot;None&quot;. If the remaining quantity is greater than 99, the value is &quot;Available&quot;. If the remaining quantity is between 1 and 99, the specific number is returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>33</para>
                        /// </summary>
                        [NameInMap("stock")]
                        [Validation(Required=false)]
                        public string Stock { get; set; }

                    }

                    /// <summary>
                    /// <para>The segment index of the trip.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public string SegmentIndex { get; set; }

                    /// <summary>
                    /// <para>The train number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>K2345</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                    /// <summary>
                    /// <para>The train type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("train_type")]
                    [Validation(Required=false)]
                    public string TrainType { get; set; }

                }

                /// <summary>
                /// <para>The transfer type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("transfer_type")]
                [Validation(Required=false)]
                public string TransferType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc81a17090871660176894d008c</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
