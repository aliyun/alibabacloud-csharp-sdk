// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListWebHostingFilesRequest : TeaModel {
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
