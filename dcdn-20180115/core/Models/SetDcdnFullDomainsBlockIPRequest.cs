// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnFullDomainsBlockIPRequest : TeaModel {
        [NameInMap("BlockInterval")]
        [Validation(Required=false)]
        public int? BlockInterval { get; set; }

        [NameInMap("IPList")]
        [Validation(Required=false)]
        public string IPList { get; set; }

        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
