// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class VipMigrationRequest : TeaModel {
        [NameInMap("NewVip")]
        [Validation(Required=false)]
        public string NewVip { get; set; }

        [NameInMap("OriginalVip")]
        [Validation(Required=false)]
        public string OriginalVip { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
