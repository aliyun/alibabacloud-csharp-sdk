// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class InstallCmsExporterRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CmsArgs")]
        [Validation(Required=false)]
        public string CmsArgs { get; set; }

        [NameInMap("DirectArgs")]
        [Validation(Required=false)]
        public string DirectArgs { get; set; }

        [NameInMap("EnableTag")]
        [Validation(Required=false)]
        public bool? EnableTag { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
