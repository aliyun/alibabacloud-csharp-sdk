// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AppMallsService20180224.Models
{
    public class TaobaoFilmGetHotShowsResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Shows")]
        [Validation(Required=false)]
        public List<TaobaoFilmGetHotShowsResponseBodyShows> Shows { get; set; }
        public class TaobaoFilmGetHotShowsResponseBodyShows : TeaModel {
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

            [NameInMap("ShowMark")]
            [Validation(Required=false)]
            public string ShowMark { get; set; }

            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            [NameInMap("ShowNameEn")]
            [Validation(Required=false)]
            public string ShowNameEn { get; set; }

            [NameInMap("ShowVersionList")]
            [Validation(Required=false)]
            public List<string> ShowVersionList { get; set; }

            [NameInMap("TrailerList")]
            [Validation(Required=false)]
            public List<string> TrailerList { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMsg")]
        [Validation(Required=false)]
        public string SubMsg { get; set; }

    }

}
