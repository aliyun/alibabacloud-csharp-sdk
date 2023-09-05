// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgx_dcap_server20200726.Models
{
    public class SimplePackagePckCertRequest : TeaModel {
        [NameInMap("cpusvn")]
        [Validation(Required=false)]
        public string Cpusvn { get; set; }

        [NameInMap("encrypted_ppid")]
        [Validation(Required=false)]
        public string EncryptedPpid { get; set; }

        [NameInMap("pceid")]
        [Validation(Required=false)]
        public string Pceid { get; set; }

        [NameInMap("pcesvn")]
        [Validation(Required=false)]
        public string Pcesvn { get; set; }

        [NameInMap("qeid")]
        [Validation(Required=false)]
        public string Qeid { get; set; }

    }

}
