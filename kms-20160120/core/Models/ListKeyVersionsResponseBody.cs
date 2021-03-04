// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeyVersionsResponseBody : TeaModel {
        [NameInMap("KeyVersions")]
        [Validation(Required=false)]
        public ListKeyVersionsResponseBodyKeyVersions KeyVersions { get; set; }
        public class ListKeyVersionsResponseBodyKeyVersions : TeaModel {
            [NameInMap("KeyVersion")]
            [Validation(Required=false)]
            public List<ListKeyVersionsResponseBodyKeyVersionsKeyVersion> KeyVersion { get; set; }
            public class ListKeyVersionsResponseBodyKeyVersionsKeyVersion : TeaModel {
                public string KeyVersionId { get; set; }
                public string KeyId { get; set; }
                public string CreationDate { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
