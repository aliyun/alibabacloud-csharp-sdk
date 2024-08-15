// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateServiceGroupSpecialDaySchedulingRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("schedulingDate")]
        [Validation(Required=false)]
        public string SchedulingDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("schedulingSpecialDays")]
        [Validation(Required=false)]
        public List<UpdateServiceGroupSpecialDaySchedulingRequestSchedulingSpecialDays> SchedulingSpecialDays { get; set; }
        public class UpdateServiceGroupSpecialDaySchedulingRequestSchedulingSpecialDays : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("schedulingEndTime")]
            [Validation(Required=false)]
            public string SchedulingEndTime { get; set; }

            [NameInMap("schedulingObjectType")]
            [Validation(Required=false)]
            public string SchedulingObjectType { get; set; }

            [NameInMap("schedulingOrder")]
            [Validation(Required=false)]
            public int? SchedulingOrder { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("schedulingStartTime")]
            [Validation(Required=false)]
            public string SchedulingStartTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("schedulingUserId")]
            [Validation(Required=false)]
            public long? SchedulingUserId { get; set; }

            [NameInMap("schedulingUserIdList")]
            [Validation(Required=false)]
            public List<long?> SchedulingUserIdList { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

    }

}
