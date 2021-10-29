// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210120.Models
{
    public class ImageAmazonRequest : TeaModel {
        [NameInMap("Gif")]
        [Validation(Required=false)]
        public bool? Gif { get; set; }

        [NameInMap("ImgUrlList")]
        [Validation(Required=false)]
        public string ImgUrlList { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("TemplateMode")]
        [Validation(Required=false)]
        public string TemplateMode { get; set; }

        [NameInMap("TextList")]
        [Validation(Required=false)]
        public List<string> TextList { get; set; }

    }

}
