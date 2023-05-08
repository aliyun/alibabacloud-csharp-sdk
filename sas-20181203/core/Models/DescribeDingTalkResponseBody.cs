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
            /// DescribeDingTalk
            /// </summary>
            [NameInMap("ActionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The modification time.
            /// </summary>
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public string ConfigList { get; set; }

            [NameInMap("DingTalkLang")]
            [Validation(Required=false)]
            public string DingTalkLang { get; set; }

            /// <summary>
            /// Obtains DingTalk notifications.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("GroupIdList")]
            [Validation(Required=false)]
            public string GroupIdList { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("IntervalTime")]
            [Validation(Required=false)]
            public int? IntervalTime { get; set; }

            /// <summary>
            /// The list of notification settings.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// ```
            /// http(s)://[Endpoint]/?Action=DescribeDingTalk
            /// &<公共请求参数>
            /// ```
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The status of the notification. Valid values:
        /// 
        /// *   **0**: disabled
        /// *   **1**: enabled
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeDingTalkResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeDingTalkResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The ID of the notification.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The name of the notification.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// Alert notification
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// [{\"type\":\"vul\",\"configItemList\":[{\"key\":\"key\", \"valueList\":\"123\"}]}]
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
