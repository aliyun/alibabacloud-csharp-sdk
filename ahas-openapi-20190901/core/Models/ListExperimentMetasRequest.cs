// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ListExperimentMetasRequest : TeaModel {
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("NameSpace")]
        [Validation(Required=false)]
        public string NameSpace { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("AhasRegionId")]
        [Validation(Required=false)]
        public string AhasRegionId { get; set; }

    }

}
