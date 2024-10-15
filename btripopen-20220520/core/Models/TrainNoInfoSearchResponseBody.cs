// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoInfoSearchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
            [NameInMap("train_station_search_v_o")]
            [Validation(Required=false)]
            public TrainNoInfoSearchResponseBodyModuleTrainStationSearchVO TrainStationSearchVO { get; set; }
            public class TrainNoInfoSearchResponseBodyModuleTrainStationSearchVO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("arr_day_tag")]
                [Validation(Required=false)]
                public string ArrDayTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BDC</para>
                /// </summary>
                [NameInMap("arr_station_code")]
                [Validation(Required=false)]
                public string ArrStationCode { get; set; }

                [NameInMap("arr_station_name")]
                [Validation(Required=false)]
                public string ArrStationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-07 15:19:01</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("cost_time")]
                [Validation(Required=false)]
                public string CostTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BTC</para>
                /// </summary>
                [NameInMap("dep_station_code")]
                [Validation(Required=false)]
                public string DepStationCode { get; set; }

                [NameInMap("dep_station_name")]
                [Validation(Required=false)]
                public string DepStationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-06 15:19:01</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("is_end_station")]
                [Validation(Required=false)]
                public int? IsEndStation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("is_start_station")]
                [Validation(Required=false)]
                public int? IsStartStation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>54000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("sale_flag")]
                [Validation(Required=false)]
                public string SaleFlag { get; set; }

                [NameInMap("seat_infos")]
                [Validation(Required=false)]
                public List<TrainNoInfoSearchResponseBodyModuleTrainStationSearchVOSeatInfos> SeatInfos { get; set; }
                public class TrainNoInfoSearchResponseBodyModuleTrainStationSearchVOSeatInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    [NameInMap("seat_name")]
                    [Validation(Required=false)]
                    public string SeatName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("seat_type")]
                    [Validation(Required=false)]
                    public string SeatType { get; set; }

                    [NameInMap("stock")]
                    [Validation(Required=false)]
                    public string Stock { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>k2345</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("train_type")]
                [Validation(Required=false)]
                public string TrainType { get; set; }

            }

            [NameInMap("train_transfer_station_search_v_o")]
            [Validation(Required=false)]
            public TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVO TrainTransferStationSearchVO { get; set; }
            public class TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVO : TeaModel {
                [NameInMap("transfer_detail_list")]
                [Validation(Required=false)]
                public List<TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVOTransferDetailList> TransferDetailList { get; set; }
                public class TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVOTransferDetailList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("arr_day_tag")]
                    [Validation(Required=false)]
                    public string ArrDayTag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BDC</para>
                    /// </summary>
                    [NameInMap("arr_station_code")]
                    [Validation(Required=false)]
                    public string ArrStationCode { get; set; }

                    [NameInMap("arr_station_name")]
                    [Validation(Required=false)]
                    public string ArrStationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>111</para>
                    /// </summary>
                    [NameInMap("cost_time")]
                    [Validation(Required=false)]
                    public string CostTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BTC</para>
                    /// </summary>
                    [NameInMap("dep_station_code")]
                    [Validation(Required=false)]
                    public string DepStationCode { get; set; }

                    [NameInMap("dep_station_name")]
                    [Validation(Required=false)]
                    public string DepStationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-06 15:19:01</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("is_end_station")]
                    [Validation(Required=false)]
                    public int? IsEndStation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("is_start_station")]
                    [Validation(Required=false)]
                    public int? IsStartStation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>54000</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sale_flag")]
                    [Validation(Required=false)]
                    public string SaleFlag { get; set; }

                    [NameInMap("seat_infos")]
                    [Validation(Required=false)]
                    public List<TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVOTransferDetailListSeatInfos> SeatInfos { get; set; }
                    public class TrainNoInfoSearchResponseBodyModuleTrainTransferStationSearchVOTransferDetailListSeatInfos : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>67000</para>
                        /// </summary>
                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public long? Price { get; set; }

                        [NameInMap("seat_name")]
                        [Validation(Required=false)]
                        public string SeatName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>14</para>
                        /// </summary>
                        [NameInMap("seat_type")]
                        [Validation(Required=false)]
                        public string SeatType { get; set; }

                        [NameInMap("stock")]
                        [Validation(Required=false)]
                        public string Stock { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>D1234</para>
                    /// </summary>
                    [NameInMap("train_no")]
                    [Validation(Required=false)]
                    public string TrainNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("train_type")]
                    [Validation(Required=false)]
                    public string TrainType { get; set; }

                }

                /// <summary>
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
