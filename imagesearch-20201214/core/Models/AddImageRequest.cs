/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class AddImageRequest : TeaModel {
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public int? CategoryId { get; set; }

        [NameInMap("Crop")]
        [Validation(Required=false)]
        public bool? Crop { get; set; }

        [NameInMap("CustomContent")]
        [Validation(Required=false)]
        public string CustomContent { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("IntAttr")]
        [Validation(Required=false)]
        public int? IntAttr { get; set; }

        [NameInMap("IntAttr2")]
        [Validation(Required=false)]
        public int? IntAttr2 { get; set; }

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

        [NameInMap("StrAttr")]
        [Validation(Required=false)]
        public string StrAttr { get; set; }

        [NameInMap("StrAttr2")]
        [Validation(Required=false)]
        public string StrAttr2 { get; set; }

    }

}
