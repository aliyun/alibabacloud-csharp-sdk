// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class SetCacheOperateSyncRequest : TeaModel {
        [NameInMap("ExceptVersion")]
        [Validation(Required=false)]
        public int? ExceptVersion { get; set; }

        [NameInMap("ExpireSeconds")]
        [Validation(Required=false)]
        public int? ExpireSeconds { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("SetType")]
        [Validation(Required=false)]
        public string SetType { get; set; }

        [NameInMap("ValueClazz")]
        [Validation(Required=false)]
        public string ValueClazz { get; set; }

        [NameInMap("ValueString")]
        [Validation(Required=false)]
        public string ValueString { get; set; }

    }

}
