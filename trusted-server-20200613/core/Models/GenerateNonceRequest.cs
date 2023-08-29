// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class GenerateNonceRequest : TeaModel {
        [NameInMap("AikName")]
        [Validation(Required=false)]
        public string AikName { get; set; }

        [NameInMap("EkCert")]
        [Validation(Required=false)]
        public string EkCert { get; set; }

        [NameInMap("EkPub")]
        [Validation(Required=false)]
        public string EkPub { get; set; }

        [NameInMap("PropertyUuid")]
        [Validation(Required=false)]
        public string PropertyUuid { get; set; }

    }

}
