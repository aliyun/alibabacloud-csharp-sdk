// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyADInfoRequest : TeaModel {
        [NameInMap("ADAccountName")]
        [Validation(Required=false)]
        public string ADAccountName { get; set; }

        [NameInMap("ADDNS")]
        [Validation(Required=false)]
        public string ADDNS { get; set; }

        [NameInMap("ADPassword")]
        [Validation(Required=false)]
        public string ADPassword { get; set; }

        [NameInMap("ADServerIpAddress")]
        [Validation(Required=false)]
        public string ADServerIpAddress { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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
