// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPResponseBody : TeaModel {
        [NameInMap("DstIPList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDestinationIPResponseBodyDstIPList> DstIPList { get; set; }
        public class DescribeOutgoingDestinationIPResponseBodyDstIPList : TeaModel {
            [NameInMap("AclCoverage")]
            [Validation(Required=false)]
            public string AclCoverage { get; set; }

            [NameInMap("AclRecommendDetail")]
            [Validation(Required=false)]
            public string AclRecommendDetail { get; set; }

            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            [NameInMap("AddressGroupName")]
            [Validation(Required=false)]
            public string AddressGroupName { get; set; }

            [NameInMap("AddressGroupUUID")]
            [Validation(Required=false)]
            public string AddressGroupUUID { get; set; }

            [NameInMap("ApplicationPortList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList> ApplicationPortList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListApplicationPortList : TeaModel {
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("HasAclRecommend")]
            [Validation(Required=false)]
            public bool? HasAclRecommend { get; set; }

            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            [NameInMap("IsMarkNormal")]
            [Validation(Required=false)]
            public bool? IsMarkNormal { get; set; }

            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("SecuritySuggest")]
            [Validation(Required=false)]
            public string SecuritySuggest { get; set; }

            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDestinationIPResponseBodyDstIPListTagList> TagList { get; set; }
            public class DescribeOutgoingDestinationIPResponseBodyDstIPListTagList : TeaModel {
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                [NameInMap("TagDescribe")]
                [Validation(Required=false)]
                public string TagDescribe { get; set; }

                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
