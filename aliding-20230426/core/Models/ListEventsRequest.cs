// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListEventsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        [NameInMap("MaxAttendees")]
        [Validation(Required=false)]
        public int? MaxAttendees { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("SeriesMasterId")]
        [Validation(Required=false)]
        public string SeriesMasterId { get; set; }

        [NameInMap("ShowDeleted")]
        [Validation(Required=false)]
        public bool? ShowDeleted { get; set; }

        [NameInMap("SyncToken")]
        [Validation(Required=false)]
        public string SyncToken { get; set; }

        [NameInMap("TimeMax")]
        [Validation(Required=false)]
        public string TimeMax { get; set; }

        [NameInMap("TimeMin")]
        [Validation(Required=false)]
        public string TimeMin { get; set; }

    }

}
