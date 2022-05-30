// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDutyRostersResponseBody : TeaModel {
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public ListDutyRostersResponseBodyPaging Paging { get; set; }
        public class ListDutyRostersResponseBodyPaging : TeaModel {
            [NameInMap("DutyRosters")]
            [Validation(Required=false)]
            public List<ListDutyRostersResponseBodyPagingDutyRosters> DutyRosters { get; set; }
            public class ListDutyRostersResponseBodyPagingDutyRosters : TeaModel {
                public string DutyRosterIdentifier { get; set; }
                public string DutyRosterName { get; set; }
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
