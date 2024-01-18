// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryUpcomingMoviesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Movies")]
        [Validation(Required=false)]
        public QueryUpcomingMoviesResponseBodyMovies Movies { get; set; }
        public class QueryUpcomingMoviesResponseBodyMovies : TeaModel {
            [NameInMap("Movie")]
            [Validation(Required=false)]
            public List<QueryUpcomingMoviesResponseBodyMoviesMovie> Movie { get; set; }
            public class QueryUpcomingMoviesResponseBodyMoviesMovie : TeaModel {
                [NameInMap("BackgroundPicture")]
                [Validation(Required=false)]
                public string BackgroundPicture { get; set; }

                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Director")]
                [Validation(Required=false)]
                public string Director { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("Highlight")]
                [Validation(Required=false)]
                public string Highlight { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("LeadingRole")]
                [Validation(Required=false)]
                public string LeadingRole { get; set; }

                [NameInMap("MovieName")]
                [Validation(Required=false)]
                public string MovieName { get; set; }

                [NameInMap("MovieNameEn")]
                [Validation(Required=false)]
                public string MovieNameEn { get; set; }

                [NameInMap("MovieTypeList")]
                [Validation(Required=false)]
                public string MovieTypeList { get; set; }

                [NameInMap("MovieVersion")]
                [Validation(Required=false)]
                public string MovieVersion { get; set; }

                [NameInMap("OpenDay")]
                [Validation(Required=false)]
                public string OpenDay { get; set; }

                [NameInMap("OpenTime")]
                [Validation(Required=false)]
                public string OpenTime { get; set; }

                [NameInMap("Poster")]
                [Validation(Required=false)]
                public string Poster { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("TrailerList")]
                [Validation(Required=false)]
                public string TrailerList { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
