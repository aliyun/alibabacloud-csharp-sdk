// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class CertificateQualityRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("FileInfo")]
        [Validation(Required=false)]
        public string FileInfo { get; set; }

        [NameInMap("FileStoreType")]
        [Validation(Required=false)]
        public string FileStoreType { get; set; }

        [NameInMap("CertificateType")]
        [Validation(Required=false)]
        public string CertificateType { get; set; }

    }

}
