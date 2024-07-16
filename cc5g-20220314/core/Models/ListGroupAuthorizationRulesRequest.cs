// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListGroupAuthorizationRulesRequest : TeaModel {
        [NameInMap("AuthorizationRuleIds")]
        [Validation(Required=false)]
        public List<string> AuthorizationRuleIds { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        [NameInMap("DestinationPort")]
        [Validation(Required=false)]
        public string DestinationPort { get; set; }

        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        [NameInMap("Dns")]
        [Validation(Required=false)]
        public bool? Dns { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("Names")]
        [Validation(Required=false)]
        public List<string> Names { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WirelessCloudConnectorGroupId")]
        [Validation(Required=false)]
        public string WirelessCloudConnectorGroupId { get; set; }

    }

}
