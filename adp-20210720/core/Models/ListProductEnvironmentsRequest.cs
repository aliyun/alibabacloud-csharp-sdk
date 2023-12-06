// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductEnvironmentsRequest : TeaModel {
        [NameInMap("compatibleProductVersionUID")]
        [Validation(Required=false)]
        public string CompatibleProductVersionUID { get; set; }

        [NameInMap("envType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public ListProductEnvironmentsRequestOptions Options { get; set; }
        public class ListProductEnvironmentsRequestOptions : TeaModel {
            [NameInMap("filterWithSpecUID")]
            [Validation(Required=false)]
            public bool? FilterWithSpecUID { get; set; }

            [NameInMap("specUID")]
            [Validation(Required=false)]
            public string SpecUID { get; set; }

        }

        [NameInMap("platforms")]
        [Validation(Required=false)]
        public List<ListProductEnvironmentsRequestPlatforms> Platforms { get; set; }
        public class ListProductEnvironmentsRequestPlatforms : TeaModel {
            [NameInMap("architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            [NameInMap("os")]
            [Validation(Required=false)]
            public string Os { get; set; }

        }

        [NameInMap("productVersionSpecUID")]
        [Validation(Required=false)]
        public string ProductVersionSpecUID { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

    }

}
