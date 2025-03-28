// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftSchedulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public ListShiftSchedulesResponseBodyPaging Paging { get; set; }
        public class ListShiftSchedulesResponseBodyPaging : TeaModel {
            /// <summary>
            /// <para>The page number. Minimum value: 1. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The shift schedules.</para>
            /// </summary>
            [NameInMap("ShiftSchedules")]
            [Validation(Required=false)]
            public List<ListShiftSchedulesResponseBodyPagingShiftSchedules> ShiftSchedules { get; set; }
            public class ListShiftSchedulesResponseBodyPagingShiftSchedules : TeaModel {
                /// <summary>
                /// <para>The unique identifier of the shift schedule. You can use the identifier to query the on-duty engineers in the shift schedule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2ab6456ada634b2f938ee******9b45b</para>
                /// </summary>
                [NameInMap("ShiftScheduleIdentifier")]
                [Validation(Required=false)]
                public string ShiftScheduleIdentifier { get; set; }

                /// <summary>
                /// <para>The name of the shift schedule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Duty table name</para>
                /// </summary>
                [NameInMap("ShiftScheduleName")]
                [Validation(Required=false)]
                public string ShiftScheduleName { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F0DBDD-5AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
