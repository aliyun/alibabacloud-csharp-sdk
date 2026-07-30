// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoInfoSearchResponseBody : TeaModel {
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
        public TrainNoInfoSearchResponseBodyModule Module { get; set; }
        public class TrainNoInfoSearchResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The direct train search result.</para>
            /// </summary>
            [NameInMap("train_station_search_v_o")]
            [Validation(Required=false)]
            public TrainNoInfoSearchResponseBodyModuleTrainStationSearchVO TrainStationSearchVO { get; set; }
            public class TrainNoInfoSearchResponseBodyModuleTrainStationSearchVO : TeaModel {
                /// <summary>
                /// <para>The number of days crossed during the journey.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("arr_day_tag")]
                [Validation(Required=false)]
                public string ArrDayTag { get; set; }

                /// <summary>
                /// <para>The code of the arrival station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BDC</para>
                /// </summary>
                [NameInMap("arr_station_code")]
                [Validation(Required=false)]
                public string ArrStationCode { get; set; }

                /// <summary>
                /// <para>The name of the arrival station.</para>
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
                /// <para>2024-05-07 15:19:01</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The travel duration, in minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("cost_time")]
                [Validation(Required=false)]
                public string CostTime { get; set; }

                /// <summary>
                /// <para>The code of the departure station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BTC</para>
                /// </summary>
                [NameInMap("dep_station_code")]
                [Validation(Required=false)]
                public string DepStationCode { get; set; }

                /// <summary>
                /// <para>The name of the departure station.</para>
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
                /// <para>2024-05-06 15:19:01</para>
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
                /// <para>The price, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>54000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                /// <summary>
                /// <para>Indicates whether the train can be booked. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Yes.</description></item>
                /// <item><description>0: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("sale_flag")]
                [Validation(Required=false)]
                public string SaleFlag { get; set; }

                /// <summary>
                /// <para>The seat information.</para>
                /// </summary>
                [NameInMap("seat_infos")]
                [Validation(Required=false)]
                public List<TrainNoInfoSearchResponseBodyModuleTrainStationSearchVOSeatInfos> SeatInfos { get; set; }
                public class TrainNoInfoSearchResponseBodyModuleTrainStationSearchVOSeatInfos : TeaModel {
                    /// <summary>
                    /// <para>The price, in cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
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
                /// <para>k2345</para>
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
            /// <para>The transfer train search result.</para>
            /// </summary>
            [NameInMap("train_transfer_station_search_v_o")]
            [Validation(Required=false)]
            public TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVO TrainTransferStationSearchVO { get; set; }
            public class TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVO : TeaModel {
                /// <summary>
                /// <para>The list of transfer trains.</para>
                /// </summary>
                [NameInMap("transfer_detail_list")]
                [Validation(Required=false)]
                public List<TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVOTransferDetailList> TransferDetailList { get; set; }
                public class TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVOTransferDetailList : TeaModel {
                    /// <summary>
                    /// <para>The number of days crossed during the journey.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("arr_day_tag")]
                    [Validation(Required=false)]
                    public string ArrDayTag { get; set; }

                    /// <summary>
                    /// <para>The code of the arrival station.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BDC</para>
                    /// </summary>
                    [NameInMap("arr_station_code")]
                    [Validation(Required=false)]
                    public string ArrStationCode { get; set; }

                    /// <summary>
                    /// <para>The name of the arrival station.</para>
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
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The travel duration, in minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>111</para>
                    /// </summary>
                    [NameInMap("cost_time")]
                    [Validation(Required=false)]
                    public string CostTime { get; set; }

                    /// <summary>
                    /// <para>The code of the departure station.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BTC</para>
                    /// </summary>
                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    /// <summary>
                    /// <para>The name of the departure station.</para>
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
                    /// <para>2024-05-06 15:19:01</para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("is_start_station")]
                    [Validation(Required=false)]
                    public int? IsStartStation { get; set; }

                    /// <summary>
                    /// <para>The price, in cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>54000</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the train can be booked. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: Yes.</description></item>
                    /// <item><description>0: No.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sale_flag")]
                    [Validation(Required=false)]
                    public string SaleFlag { get; set; }

                    /// <summary>
                    /// <para>The seat information.</para>
                    /// </summary>
                    [NameInMap("seat_infos")]
                    [Validation(Required=false)]
                    public List<TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVOTransferDetailListSeatInfos> SeatInfos { get; set; }
                    public class TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVOTransferDetailListSeatInfos : TeaModel {
                        /// <summary>
                        /// <para>The price, in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>67000</para>
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
                    /// <para>D1234</para>
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
                /// <para>The transfer type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Same-station transfer.</description></item>
                /// <item><description>2: Cross-station transfer.</description></item>
                /// <item><description>3: Same-train transfer.</description></item>
                /// <item><description>-1: Unknown.</description></item>
                /// </list>
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
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2136019116915615924561621e06ee</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
