// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CopyThingModelRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SourceProductKey")]
        [Validation(Required=false)]
        public string SourceProductKey { get; set; }

        [NameInMap("TargetProductKey")]
        [Validation(Required=false)]
        public string TargetProductKey { get; set; }

        [NameInMap("SourceModelVersion")]
        [Validation(Required=false)]
        public string SourceModelVersion { get; set; }

        [NameInMap("RealTenantId")]
        [Validation(Required=false)]
        public string RealTenantId { get; set; }

        [NameInMap("RealTripartiteKey")]
        [Validation(Required=false)]
        public string RealTripartiteKey { get; set; }

    }

}
