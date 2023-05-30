// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventListRequest : TeaModel {
        /// <summary>
        /// The IP address of the affected asset.
        /// </summary>
        [NameInMap("AssetsIP")]
        [Validation(Required=false)]
        public string AssetsIP { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("AssetsInstanceId")]
        [Validation(Required=false)]
        public string AssetsInstanceId { get; set; }

        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("AssetsInstanceName")]
        [Validation(Required=false)]
        public string AssetsInstanceName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds. If you do not specify this parameter, the query ends at the current time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the breach awareness event.
        /// </summary>
        [NameInMap("EventKey")]
        [Validation(Required=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// The name of the breach awareness event.
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The UUID of the breach awareness event.
        /// </summary>
        [NameInMap("EventUuid")]
        [Validation(Required=false)]
        public string EventUuid { get; set; }

        /// <summary>
        /// Specifies whether the breach awareness event is ignored. Valid values:
        /// 
        /// *   **true**: The breach awareness event is ignored.
        /// *   **false**: The breach awareness event is not ignored.
        /// </summary>
        [NameInMap("IsIgnore")]
        [Validation(Required=false)]
        public string IsIgnore { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the member.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 6. Maximum value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The handling status of breach awareness events.
        /// </summary>
        [NameInMap("ProcessStatusList")]
        [Validation(Required=false)]
        public List<int?> ProcessStatusList { get; set; }

        /// <summary>
        /// The risk levels.
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public List<int?> RiskLevel { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds. If you do not specify this parameter, the query starts from 30 days before the current time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
