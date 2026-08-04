// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class IncrByCacheOperateSyncRequest : TeaModel {
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public int? DefaultValue { get; set; }

        [NameInMap("ExpireSeconds")]
        [Validation(Required=false)]
        public int? ExpireSeconds { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Step")]
        [Validation(Required=false)]
        public int? Step { get; set; }

    }

}
