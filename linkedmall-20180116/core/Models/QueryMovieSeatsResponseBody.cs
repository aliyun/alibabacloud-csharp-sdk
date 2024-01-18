// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryMovieSeatsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SeatMap")]
        [Validation(Required=false)]
        public QueryMovieSeatsResponseBodySeatMap SeatMap { get; set; }
        public class QueryMovieSeatsResponseBodySeatMap : TeaModel {
            [NameInMap("MaxCanBuy")]
            [Validation(Required=false)]
            public long? MaxCanBuy { get; set; }

            [NameInMap("MaxColumn")]
            [Validation(Required=false)]
            public long? MaxColumn { get; set; }

            [NameInMap("MaxLeftPx")]
            [Validation(Required=false)]
            public long? MaxLeftPx { get; set; }

            [NameInMap("MaxRow")]
            [Validation(Required=false)]
            public long? MaxRow { get; set; }

            [NameInMap("MaxTopPx")]
            [Validation(Required=false)]
            public long? MaxTopPx { get; set; }

            [NameInMap("MinColumn")]
            [Validation(Required=false)]
            public long? MinColumn { get; set; }

            [NameInMap("MinLeftPx")]
            [Validation(Required=false)]
            public long? MinLeftPx { get; set; }

            [NameInMap("MinRow")]
            [Validation(Required=false)]
            public long? MinRow { get; set; }

            [NameInMap("MinTopPx")]
            [Validation(Required=false)]
            public long? MinTopPx { get; set; }

            [NameInMap("Notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }

            [NameInMap("Regular")]
            [Validation(Required=false)]
            public bool? Regular { get; set; }

            [NameInMap("SeatCount")]
            [Validation(Required=false)]
            public long? SeatCount { get; set; }

            [NameInMap("Seats")]
            [Validation(Required=false)]
            public QueryMovieSeatsResponseBodySeatMapSeats Seats { get; set; }
            public class QueryMovieSeatsResponseBodySeatMapSeats : TeaModel {
                [NameInMap("Seat")]
                [Validation(Required=false)]
                public List<QueryMovieSeatsResponseBodySeatMapSeatsSeat> Seat { get; set; }
                public class QueryMovieSeatsResponseBodySeatMapSeatsSeat : TeaModel {
                    [NameInMap("Area")]
                    [Validation(Required=false)]
                    public string Area { get; set; }

                    [NameInMap("Column")]
                    [Validation(Required=false)]
                    public long? Column { get; set; }

                    [NameInMap("ExtId")]
                    [Validation(Required=false)]
                    public string ExtId { get; set; }

                    [NameInMap("Flag")]
                    [Validation(Required=false)]
                    public long? Flag { get; set; }

                    [NameInMap("LeftPx")]
                    [Validation(Required=false)]
                    public long? LeftPx { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Row")]
                    [Validation(Required=false)]
                    public long? Row { get; set; }

                    [NameInMap("RowName")]
                    [Validation(Required=false)]
                    public string RowName { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    [NameInMap("TopPx")]
                    [Validation(Required=false)]
                    public long? TopPx { get; set; }

                }

            }

            [NameInMap("SoldCount")]
            [Validation(Required=false)]
            public long? SoldCount { get; set; }

            [NameInMap("TipMessage")]
            [Validation(Required=false)]
            public string TipMessage { get; set; }

        }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
