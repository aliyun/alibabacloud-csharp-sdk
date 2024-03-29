// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListWirelessCloudConnectorGroupsRequest : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("WirelessCloudConnectorGroupIds")]
        [Validation(Required=false)]
        public List<string> WirelessCloudConnectorGroupIds { get; set; }

        [NameInMap("WirelessCloudConnectorGroupNames")]
        [Validation(Required=false)]
        public List<string> WirelessCloudConnectorGroupNames { get; set; }

        [NameInMap("WirelessCloudConnectorGroupStatus")]
        [Validation(Required=false)]
        public List<string> WirelessCloudConnectorGroupStatus { get; set; }

    }

}
