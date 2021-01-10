// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryHotMoviesResponseBody : TeaModel {
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
        public QueryHotMoviesResponseBodyMovies Movies { get; set; }
        public class QueryHotMoviesResponseBodyMovies : TeaModel {
            [NameInMap("Movie")]
            [Validation(Required=false)]
            public List<QueryHotMoviesResponseBodyMoviesMovie> Movie { get; set; }
            public class QueryHotMoviesResponseBodyMoviesMovie : TeaModel {
                public string MovieVersion { get; set; }
                public string Type { get; set; }
                public string BackgroundPicture { get; set; }
                public string OpenDay { get; set; }
                public string Remark { get; set; }
                public string Highlight { get; set; }
                public QueryHotMoviesResponseBodyMoviesMovieMovieTypeList MovieTypeList { get; set; }
                public class QueryHotMoviesResponseBodyMoviesMovieMovieTypeList : TeaModel {
                    [NameInMap("MovieTypeList")]
                    [Validation(Required=false)]
                    public List<string> MovieTypeList { get; set; }

                }
                public string Language { get; set; }
                public string Director { get; set; }
                public string OpenTime { get; set; }
                public string Poster { get; set; }
                public string MovieName { get; set; }
                public string Description { get; set; }
                public string Country { get; set; }
                public long? Duration { get; set; }
                public string MovieNameEn { get; set; }
                public string LeadingRole { get; set; }
                public long? Id { get; set; }
                public QueryHotMoviesResponseBodyMoviesMovieTrailerList TrailerList { get; set; }
                public class QueryHotMoviesResponseBodyMoviesMovieTrailerList : TeaModel {
                    [NameInMap("TrailerList")]
                    [Validation(Required=false)]
                    public List<string> TrailerList { get; set; }

                }
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
