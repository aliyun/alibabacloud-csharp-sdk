// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class RestartDedicatedHostRequest : TeaModel {
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        [NameInMap("FailoverMode")]
        [Validation(Required=false)]
        public string FailoverMode { get; set; }

        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
