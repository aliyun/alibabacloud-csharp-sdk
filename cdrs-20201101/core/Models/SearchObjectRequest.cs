// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class SearchObjectRequest : TeaModel {
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public string DeviceList { get; set; }

        [NameInMap("Feature")]
        [Validation(Required=false)]
        public string Feature { get; set; }

        [NameInMap("ImageContent")]
        [Validation(Required=false)]
        public string ImageContent { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ShotTimeEnd")]
        [Validation(Required=false)]
        public string ShotTimeEnd { get; set; }

        [NameInMap("ShotTimeStart")]
        [Validation(Required=false)]
        public string ShotTimeStart { get; set; }

        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
