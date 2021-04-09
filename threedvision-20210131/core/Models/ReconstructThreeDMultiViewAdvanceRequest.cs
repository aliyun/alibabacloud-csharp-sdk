// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class ReconstructThreeDMultiViewAdvanceRequest : TeaModel {
        [NameInMap("ZipFileUrlObject")]
        [Validation(Required=true)]
        public Stream ZipFileUrlObject { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
