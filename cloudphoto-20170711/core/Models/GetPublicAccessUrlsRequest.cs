// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class GetPublicAccessUrlsRequest : TeaModel {
        [NameInMap("ZoomType")]
        [Validation(Required=false)]
        public string ZoomType { get; set; }

        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("LibraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        [NameInMap("PhotoId")]
        [Validation(Required=false)]
        public List<int?> PhotoId { get; set; }

    }

}
