// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class AddSecretBlacklistRequest : TeaModel {
        [NameInMap("BlackNo")]
        [Validation(Required=false)]
        public string BlackNo { get; set; }

        [NameInMap("BlackType")]
        [Validation(Required=false)]
        public string BlackType { get; set; }

        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("WayControl")]
        [Validation(Required=false)]
        public string WayControl { get; set; }

    }

}
