// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GenerateSysAppDownloadInfoRequest : TeaModel {
        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public string Plugins { get; set; }

        [NameInMap("SignMode")]
        [Validation(Required=false)]
        public string SignMode { get; set; }

        [NameInMap("OsType")]
        [Validation(Required=false)]
        public int? OsType { get; set; }

        [NameInMap("PkgName")]
        [Validation(Required=false)]
        public string PkgName { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("CertFileObjectKey")]
        [Validation(Required=false)]
        public string CertFileObjectKey { get; set; }

    }

}
