// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20190325.Models
{
    public class SearchImageRequest : TeaModel {
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public int? CategoryId { get; set; }

        [NameInMap("Crop")]
        [Validation(Required=false)]
        public bool? Crop { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        [NameInMap("PicContent")]
        [Validation(Required=false)]
        public string PicContent { get; set; }

        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
