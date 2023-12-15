// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ApplyBlockchainRequest : TeaModel {
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        [NameInMap("AccountPubKey")]
        [Validation(Required=false)]
        public string AccountPubKey { get; set; }

        [NameInMap("AccountRecoverPubKey")]
        [Validation(Required=false)]
        public string AccountRecoverPubKey { get; set; }

        [NameInMap("Blockchain")]
        [Validation(Required=false)]
        public string Blockchain { get; set; }

        [NameInMap("UploadReq")]
        [Validation(Required=false)]
        public string UploadReq { get; set; }

    }

}
