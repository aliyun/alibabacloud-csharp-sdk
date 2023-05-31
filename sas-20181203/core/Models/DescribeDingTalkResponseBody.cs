// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDingTalkResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of details of notifications.
        /// </summary>
        [NameInMap("ActionList")]
        [Validation(Required=false)]
        public List<DescribeDingTalkResponseBodyActionList> ActionList { get; set; }
        public class DescribeDingTalkResponseBodyActionList : TeaModel {
            /// <summary>
            /// The name of the notification.
            /// </summary>
            [NameInMap("ActionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            /// <summary>
            /// The UID of the user.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The list of notification settings.
            /// </summary>
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public string ConfigList { get; set; }

            /// <summary>
            /// The language of the content within notifications. Valid values:
            /// 
            /// *   **zh**: Chinese
            /// *   **en**: English
            /// </summary>
            [NameInMap("DingTalkLang")]
            [Validation(Required=false)]
            public string DingTalkLang { get; set; }

            /// <summary>
            /// The creation time. unit:millisecond.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The modification time.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The group IDs.
            /// </summary>
            [NameInMap("GroupIdList")]
            [Validation(Required=false)]
            public string GroupIdList { get; set; }

            /// <summary>
            /// The ID of the notification.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The interval at which the notifications are sent.unit:minute.
            /// </summary>
            [NameInMap("IntervalTime")]
            [Validation(Required=false)]
            public int? IntervalTime { get; set; }

            /// <summary>
            /// The status of the notification. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The parameters of the notification.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeDingTalkResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeDingTalkResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of messages.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
