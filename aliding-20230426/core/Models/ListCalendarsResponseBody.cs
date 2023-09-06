// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListCalendarsResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("response")]
        [Validation(Required=false)]
        public ListCalendarsResponseBodyResponse Response { get; set; }
        public class ListCalendarsResponseBodyResponse : TeaModel {
            [NameInMap("Calendars")]
            [Validation(Required=false)]
            public List<ListCalendarsResponseBodyResponseCalendars> Calendars { get; set; }
            public class ListCalendarsResponseBodyResponseCalendars : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ETag")]
                [Validation(Required=false)]
                public string ETag { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Privilege")]
                [Validation(Required=false)]
                public string Privilege { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
