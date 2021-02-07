// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class CreatePkgVersionRequest : TeaModel {
        [NameInMap("PkgVersionLabel")]
        [Validation(Required=false)]
        public string PkgVersionLabel { get; set; }

        [NameInMap("PkgVersionDescription")]
        [Validation(Required=false)]
        public string PkgVersionDescription { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("PackageSource")]
        [Validation(Required=false)]
        public string PackageSource { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
