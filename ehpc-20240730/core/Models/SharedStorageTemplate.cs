// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class SharedStorageTemplate : TeaModel {
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("MountDirectory")]
        [Validation(Required=false)]
        public string MountDirectory { get; set; }

        [NameInMap("MountOptions")]
        [Validation(Required=false)]
        public string MountOptions { get; set; }

        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        [NameInMap("NASDirectory")]
        [Validation(Required=false)]
        public string NASDirectory { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

    }

}
