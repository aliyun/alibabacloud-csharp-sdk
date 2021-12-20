// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class CreateIoTCloudConnectorRequest : TeaModel {
        [NameInMap("APN")]
        [Validation(Required=false)]
        public string APN { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        [NameInMap("IoTCloudConnectorDescription")]
        [Validation(Required=false)]
        public string IoTCloudConnectorDescription { get; set; }

        [NameInMap("IoTCloudConnectorName")]
        [Validation(Required=false)]
        public string IoTCloudConnectorName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceUid")]
        [Validation(Required=false)]
        public long? ResourceUid { get; set; }

        [NameInMap("WildcardDomainEnabled")]
        [Validation(Required=false)]
        public bool? WildcardDomainEnabled { get; set; }

    }

}
