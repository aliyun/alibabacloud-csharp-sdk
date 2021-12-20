// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class UpdateConnectionPoolAttributeRequest : TeaModel {
        [NameInMap("Cidrs")]
        [Validation(Required=false)]
        public List<string> Cidrs { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ConnectionPoolDescription")]
        [Validation(Required=false)]
        public string ConnectionPoolDescription { get; set; }

        [NameInMap("ConnectionPoolId")]
        [Validation(Required=false)]
        public string ConnectionPoolId { get; set; }

        [NameInMap("ConnectionPoolName")]
        [Validation(Required=false)]
        public string ConnectionPoolName { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("IoTCloudConnectorId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
