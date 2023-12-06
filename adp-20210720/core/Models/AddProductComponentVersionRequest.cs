// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class AddProductComponentVersionRequest : TeaModel {
        [NameInMap("componentVersionSpecUID")]
        [Validation(Required=false)]
        public string ComponentVersionSpecUID { get; set; }

        [NameInMap("componentVersionSpecValues")]
        [Validation(Required=false)]
        public string ComponentVersionSpecValues { get; set; }

        [NameInMap("releaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

    }

}
