// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDutyRosterResponseBody : TeaModel {
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public GetDutyRosterResponseBodyPaging Paging { get; set; }
        public class GetDutyRosterResponseBodyPaging : TeaModel {
            [NameInMap("DutyRoster")]
            [Validation(Required=false)]
            public List<GetDutyRosterResponseBodyPagingDutyRoster> DutyRoster { get; set; }
            public class GetDutyRosterResponseBodyPagingDutyRoster : TeaModel {
                public long? EndLong { get; set; }
                public long? StartLong { get; set; }
                public string Watchkeeper { get; set; }
                public string WatchkeeperName { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
