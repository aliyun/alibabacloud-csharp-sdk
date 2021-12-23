// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dplus20201216.Models
{
    public class CreateImageAmazonTaskRequest : TeaModel {
        [NameInMap("Gif")]
        [Validation(Required=false)]
        public bool? Gif { get; set; }

        [NameInMap("ImgUrlList")]
        [Validation(Required=false)]
        public List<string> ImgUrlList { get; set; }

        [NameInMap("TemplateMode")]
        [Validation(Required=false)]
        public string TemplateMode { get; set; }

        [NameInMap("TextList")]
        [Validation(Required=false)]
        public List<string> TextList { get; set; }

    }

}
