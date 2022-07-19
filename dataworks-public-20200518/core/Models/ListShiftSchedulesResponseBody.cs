// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftSchedulesResponseBody : TeaModel {
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public ListShiftSchedulesResponseBodyPaging Paging { get; set; }
        public class ListShiftSchedulesResponseBodyPaging : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("ShiftSchedules")]
            [Validation(Required=false)]
            public List<ListShiftSchedulesResponseBodyPagingShiftSchedules> ShiftSchedules { get; set; }
            public class ListShiftSchedulesResponseBodyPagingShiftSchedules : TeaModel {
                public string ShiftScheduleIdentifier { get; set; }
                public string ShiftScheduleName { get; set; }
            }
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
