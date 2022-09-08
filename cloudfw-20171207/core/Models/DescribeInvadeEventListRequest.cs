// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventListRequest : TeaModel {
        [NameInMap("AssetsIP")]
        [Validation(Required=false)]
        public string AssetsIP { get; set; }

        [NameInMap("AssetsInstanceId")]
        [Validation(Required=false)]
        public string AssetsInstanceId { get; set; }

        [NameInMap("AssetsInstanceName")]
        [Validation(Required=false)]
        public string AssetsInstanceName { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("EventKey")]
        [Validation(Required=false)]
        public string EventKey { get; set; }

        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        [NameInMap("EventUuid")]
        [Validation(Required=false)]
        public string EventUuid { get; set; }

        [NameInMap("IsIgnore")]
        [Validation(Required=false)]
        public string IsIgnore { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("ProcessStatusList")]
        [Validation(Required=false)]
        public List<int?> ProcessStatusList { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public List<int?> RiskLevel { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
