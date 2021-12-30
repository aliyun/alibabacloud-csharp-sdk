// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyHostShareKeyRequest : TeaModel {
        [NameInMap("HostShareKeyId")]
        [Validation(Required=false)]
        public string HostShareKeyId { get; set; }

        [NameInMap("HostShareKeyName")]
        [Validation(Required=false)]
        public string HostShareKeyName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PassPhrase")]
        [Validation(Required=false)]
        public string PassPhrase { get; set; }

        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
