// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListGroupAuthorizationRulesRequest : TeaModel {
        [NameInMap("AuthorizationRuleIds")]
        [Validation(Required=false)]
        public List<string> AuthorizationRuleIds { get; set; }

        [NameInMap("AuthorizationRuleName")]
        [Validation(Required=false)]
        public List<string> AuthorizationRuleName { get; set; }

        [NameInMap("AuthorizationRuleStatus")]
        [Validation(Required=false)]
        public List<string> AuthorizationRuleStatus { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public List<string> Destination { get; set; }

        [NameInMap("DestinationPort")]
        [Validation(Required=false)]
        public List<string> DestinationPort { get; set; }

        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public List<string> DestinationType { get; set; }

        [NameInMap("IoTCloudConnectorGroupId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorGroupId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public List<string> Policy { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public List<string> Protocol { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
