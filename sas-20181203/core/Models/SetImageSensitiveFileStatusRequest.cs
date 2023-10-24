// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetImageSensitiveFileStatusRequest : TeaModel {
        [NameInMap("ImageUuids")]
        [Validation(Required=false)]
        public string ImageUuids { get; set; }

        [NameInMap("SensitiveFileKey")]
        [Validation(Required=false)]
        public string SensitiveFileKey { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
