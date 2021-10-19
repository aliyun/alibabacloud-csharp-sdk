// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventGroupResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeRiskEventGroupResponseBodyDataList> DataList { get; set; }
        public class DescribeRiskEventGroupResponseBodyDataList : TeaModel {
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("FirstEventTime")]
            [Validation(Required=false)]
            public int? FirstEventTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public int? VulLevel { get; set; }

            [NameInMap("AttackApp")]
            [Validation(Required=false)]
            public string AttackApp { get; set; }

            [NameInMap("RuleSource")]
            [Validation(Required=false)]
            public int? RuleSource { get; set; }

            [NameInMap("RuleResult")]
            [Validation(Required=false)]
            public int? RuleResult { get; set; }

            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            [NameInMap("LastEventTime")]
            [Validation(Required=false)]
            public int? LastEventTime { get; set; }

            [NameInMap("ResourcePrivateIPList")]
            [Validation(Required=false)]
            public List<DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList> ResourcePrivateIPList { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList : TeaModel {
                [NameInMap("ResourceInstanceName")]
                [Validation(Required=false)]
                public string ResourceInstanceName { get; set; }

                [NameInMap("ResourcePrivateIP")]
                [Validation(Required=false)]
                public string ResourcePrivateIP { get; set; }

                [NameInMap("ResourceInstanceId")]
                [Validation(Required=false)]
                public string ResourceInstanceId { get; set; }

                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            [NameInMap("SrcPrivateIPList")]
            [Validation(Required=false)]
            public List<string> SrcPrivateIPList { get; set; }

            [NameInMap("VpcSrcInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListVpcSrcInfo VpcSrcInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListVpcSrcInfo : TeaModel {
                [NameInMap("EcsInstanceName")]
                [Validation(Required=false)]
                public string EcsInstanceName { get; set; }
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }
            };

            [NameInMap("VpcDstInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListVpcDstInfo VpcDstInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListVpcDstInfo : TeaModel {
                [NameInMap("EcsInstanceName")]
                [Validation(Required=false)]
                public string EcsInstanceName { get; set; }
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }
            };

            [NameInMap("IPLocationInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListIPLocationInfo IPLocationInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListIPLocationInfo : TeaModel {
                [NameInMap("CityId")]
                [Validation(Required=false)]
                public string CityId { get; set; }
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }
                [NameInMap("CountryId")]
                [Validation(Required=false)]
                public string CountryId { get; set; }
            };

        }

    }

}
