// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateVmAndSaveStockRequest : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public string Tenant { get; set; }

        [NameInMap("WorkloadUuid")]
        [Validation(Required=false)]
        public string WorkloadUuid { get; set; }

        [NameInMap("GroupUuid")]
        [Validation(Required=false)]
        public string GroupUuid { get; set; }

        [NameInMap("ResourceAttribute")]
        [Validation(Required=false)]
        public string ResourceAttribute { get; set; }

    }

}
