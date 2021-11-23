// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAutoLiveStreamRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeAutoLiveStreamRuleResponseBodyRules> Rules { get; set; }
        public class DescribeAutoLiveStreamRuleResponseBodyRules : TeaModel {
            [NameInMap("CallBack")]
            [Validation(Required=false)]
            public string CallBack { get; set; }

            [NameInMap("ChannelIdPrefixes")]
            [Validation(Required=false)]
            public List<string> ChannelIdPrefixes { get; set; }

            [NameInMap("ChannelIds")]
            [Validation(Required=false)]
            public List<string> ChannelIds { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            [NameInMap("PlayDomain")]
            [Validation(Required=false)]
            public string PlayDomain { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
