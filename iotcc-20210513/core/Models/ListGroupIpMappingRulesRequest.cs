// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListGroupIpMappingRulesRequest : TeaModel {
        [NameInMap("DestinationIps")]
        [Validation(Required=false)]
        public List<string> DestinationIps { get; set; }

        [NameInMap("IoTCloudConnectorGroupId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorGroupId { get; set; }

        [NameInMap("IpMappingRuleIds")]
        [Validation(Required=false)]
        public List<string> IpMappingRuleIds { get; set; }

        [NameInMap("IpMappingRuleNames")]
        [Validation(Required=false)]
        public List<string> IpMappingRuleNames { get; set; }

        [NameInMap("IpMappingRuleStatuses")]
        [Validation(Required=false)]
        public List<string> IpMappingRuleStatuses { get; set; }

        [NameInMap("MappingIps")]
        [Validation(Required=false)]
        public List<string> MappingIps { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
