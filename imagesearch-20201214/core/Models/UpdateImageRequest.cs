// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class UpdateImageRequest : TeaModel {
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

        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("StrAttr")]
        [Validation(Required=false)]
        public string StrAttr { get; set; }

        [NameInMap("StrAttr2")]
        [Validation(Required=false)]
        public string StrAttr2 { get; set; }

    }

}
