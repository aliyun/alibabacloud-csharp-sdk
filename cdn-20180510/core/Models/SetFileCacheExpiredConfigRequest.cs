// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetFileCacheExpiredConfigRequest : TeaModel {
        [NameInMap("CacheContent")]
        [Validation(Required=false)]
        public string CacheContent { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("TTL")]
        [Validation(Required=false)]
        public string TTL { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public string Weight { get; set; }

    }

}
