// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetIgnoreQueryStringConfigRequest : TeaModel {
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        [NameInMap("HashKeyArgs")]
        [Validation(Required=false)]
        public string HashKeyArgs { get; set; }

        [NameInMap("KeepOssArgs")]
        [Validation(Required=false)]
        public string KeepOssArgs { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
