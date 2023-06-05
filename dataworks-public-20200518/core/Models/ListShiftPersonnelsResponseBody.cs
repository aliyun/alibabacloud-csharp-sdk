// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftPersonnelsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page. Minimum value: 1. Maximum value: 100. Default value: 1.
        /// </summary>
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public ListShiftPersonnelsResponseBodyPaging Paging { get; set; }
        public class ListShiftPersonnelsResponseBodyPaging : TeaModel {
            /// <summary>
            /// The number of entries returned per page. Default value: 10. Maximum value: 100.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The UID of the on-duty engineer.
            /// </summary>
            [NameInMap("ShiftPersons")]
            [Validation(Required=false)]
            public List<ListShiftPersonnelsResponseBodyPagingShiftPersons> ShiftPersons { get; set; }
            public class ListShiftPersonnelsResponseBodyPagingShiftPersons : TeaModel {
                /// <summary>
                /// The time when the on-duty engineer ends the shift.
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The time when the on-duty engineer starts the shift.
                /// </summary>
                [NameInMap("ShiftPersonName")]
                [Validation(Required=false)]
                public string ShiftPersonName { get; set; }

                /// <summary>
                /// The name of the on-duty engineer.
                /// </summary>
                [NameInMap("ShiftPersonUID")]
                [Validation(Required=false)]
                public string ShiftPersonUID { get; set; }

            }

            /// <summary>
            /// The on-duty engineers in the shift schedule.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The pagination data.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
