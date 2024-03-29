// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryCollectionDataRequest : TeaModel {
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("IncludeValues")]
        [Validation(Required=false)]
        public bool? IncludeValues { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NamespacePassword")]
        [Validation(Required=false)]
        public string NamespacePassword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        [NameInMap("Vector")]
        [Validation(Required=false)]
        public List<double?> Vector { get; set; }

    }

}
