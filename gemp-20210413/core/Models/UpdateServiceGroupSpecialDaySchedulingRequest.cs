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

        [NameInMap("schedulingDate")]
        [Validation(Required=false)]
        public string SchedulingDate { get; set; }

        [NameInMap("schedulingSpecialDays")]
        [Validation(Required=false)]
        public List<UpdateServiceGroupSpecialDaySchedulingRequestSchedulingSpecialDays> SchedulingSpecialDays { get; set; }
        public class UpdateServiceGroupSpecialDaySchedulingRequestSchedulingSpecialDays : TeaModel {
            [NameInMap("schedulingEndTime")]
            [Validation(Required=false)]
            public string SchedulingEndTime { get; set; }

            [NameInMap("schedulingOrder")]
            [Validation(Required=false)]
            public int? SchedulingOrder { get; set; }

            [NameInMap("schedulingStartTime")]
            [Validation(Required=false)]
            public string SchedulingStartTime { get; set; }

            [NameInMap("schedulingUserId")]
            [Validation(Required=false)]
            public long? SchedulingUserId { get; set; }

        }

        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

    }

}
