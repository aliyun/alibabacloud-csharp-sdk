// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class EnableCustomInstanceBlockRecordRequest : TeaModel {
        [NameInMap("BlockIp")]
        [Validation(Required=false)]
        public string BlockIp { get; set; }

        [NameInMap("Bound")]
        [Validation(Required=false)]
        public string Bound { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
