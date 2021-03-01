// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ImportK8sClusterRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

        [NameInMap("EnableAsm")]
        [Validation(Required=false)]
        public bool? EnableAsm { get; set; }

    }

}
