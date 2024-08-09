// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class TableColumn : TeaModel {
        [NameInMap("expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        [NameInMap("metadataInfo")]
        [Validation(Required=false)]
        public MetadataInfo MetadataInfo { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
