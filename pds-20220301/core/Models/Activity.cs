// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Activity : TeaModel {
        [NameInMap("activity_id")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        [NameInMap("device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("event_type")]
        [Validation(Required=false)]
        public int? EventType { get; set; }

        [NameInMap("latest_event_time")]
        [Validation(Required=false)]
        public string LatestEventTime { get; set; }

        [NameInMap("resource_category")]
        [Validation(Required=false)]
        public int? ResourceCategory { get; set; }

        [NameInMap("resource_list")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ResourceList { get; set; }

        [NameInMap("total_resource_count")]
        [Validation(Required=false)]
        public long? TotalResourceCount { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
