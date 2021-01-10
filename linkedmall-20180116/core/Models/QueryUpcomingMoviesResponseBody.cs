// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryUpcomingMoviesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Movies")]
        [Validation(Required=false)]
        public QueryUpcomingMoviesResponseBodyMovies Movies { get; set; }
        public class QueryUpcomingMoviesResponseBodyMovies : TeaModel {
            [NameInMap("Movie")]
            [Validation(Required=false)]
            public List<QueryUpcomingMoviesResponseBodyMoviesMovie> Movie { get; set; }
            public class QueryUpcomingMoviesResponseBodyMoviesMovie : TeaModel {
                public string MovieVersion { get; set; }
                public string Type { get; set; }
                public string BackgroundPicture { get; set; }
                public string OpenDay { get; set; }
                public string Remark { get; set; }
                public string Highlight { get; set; }
                public string MovieTypeList { get; set; }
                public string Language { get; set; }
                public string OpenTime { get; set; }
                public string Director { get; set; }
                public string Poster { get; set; }
                public string MovieName { get; set; }
                public string Description { get; set; }
                public string Country { get; set; }
                public long? Duration { get; set; }
                public string MovieNameEn { get; set; }
                public string LeadingRole { get; set; }
                public long? Id { get; set; }
                public string TrailerList { get; set; }
            }
        };

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
