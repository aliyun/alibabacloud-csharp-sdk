// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftSchedulesResponseBody : TeaModel {
        /// <summary>
        /// The pagination data.
        /// </summary>
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public ListShiftSchedulesResponseBodyPaging Paging { get; set; }
        public class ListShiftSchedulesResponseBodyPaging : TeaModel {
            /// <summary>
            /// The page number of the returned page. Minimum value:1. Maximum value: 100.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The shift schedules.
            /// </summary>
            [NameInMap("ShiftSchedules")]
            [Validation(Required=false)]
            public List<ListShiftSchedulesResponseBodyPagingShiftSchedules> ShiftSchedules { get; set; }
            public class ListShiftSchedulesResponseBodyPagingShiftSchedules : TeaModel {
                /// <summary>
                /// The unique identifier of the shift schedule. You can use the identifier to query the on-duty engineers in the shift schedule.
                /// </summary>
                [NameInMap("ShiftScheduleIdentifier")]
                [Validation(Required=false)]
                public string ShiftScheduleIdentifier { get; set; }

                /// <summary>
                /// The name of the shift schedule.
                /// </summary>
                [NameInMap("ShiftScheduleName")]
                [Validation(Required=false)]
                public string ShiftScheduleName { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
