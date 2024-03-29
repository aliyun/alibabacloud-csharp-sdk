// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomEventRequest : TeaModel {
        [NameInMap("EventInfo")]
        [Validation(Required=false)]
        public List<PutCustomEventRequestEventInfo> EventInfo { get; set; }
        public class PutCustomEventRequestEventInfo : TeaModel {
            /// <summary>
            /// The content of the custom event. Valid values of N: 1 to 50.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The name of the custom event. Valid values of N: 1 to 50.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The ID of the application group. Valid values of N: 0 to 50.
            /// 
            /// Default value: 0. This value indicates that the custom event to be reported does not belong to any application group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The time when the custom event occurred.
            /// 
            /// Format: `yyyyMMddTHHmmss.SSSZ`.
            /// 
            /// Valid values of N: 1 to 50.
            /// 
            /// >  You can also specify a UNIX timestamp. Example: 1552199984000. Unit: milliseconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
