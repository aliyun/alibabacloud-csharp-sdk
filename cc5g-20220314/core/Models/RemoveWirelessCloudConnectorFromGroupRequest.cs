// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class RemoveWirelessCloudConnectorFromGroupRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("WirelessCloudConnectorGroupId")]
        [Validation(Required=false)]
        public string WirelessCloudConnectorGroupId { get; set; }

        [NameInMap("WirelessCloudConnectorIds")]
        [Validation(Required=false)]
        public List<string> WirelessCloudConnectorIds { get; set; }

    }

}
