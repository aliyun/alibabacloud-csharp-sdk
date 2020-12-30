// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Face20181203.Models
{
    public class VerifyFaceRequest : TeaModel {
        [NameInMap("ImageUrl1")]
        [Validation(Required=false)]
        public string ImageUrl1 { get; set; }

        [NameInMap("ImageUrl2")]
        [Validation(Required=false)]
        public string ImageUrl2 { get; set; }

        [NameInMap("Content1")]
        [Validation(Required=false)]
        public string Content1 { get; set; }

        [NameInMap("Content2")]
        [Validation(Required=false)]
        public string Content2 { get; set; }

    }

}
