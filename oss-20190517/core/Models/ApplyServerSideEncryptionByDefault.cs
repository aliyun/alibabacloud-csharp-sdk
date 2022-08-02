// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ApplyServerSideEncryptionByDefault : TeaModel {
        [NameInMap("KMSDataEncryption")]
        [Validation(Required=false)]
        public string KMSDataEncryption { get; set; }

        [NameInMap("KMSMasterKeyID")]
        [Validation(Required=false)]
        public string KMSMasterKeyID { get; set; }

        [NameInMap("SSEAlgorithm")]
        [Validation(Required=false)]
        public string SSEAlgorithm { get; set; }

    }

}
