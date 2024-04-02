// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class CreatCustomOcrTemplateRequest : TeaModel {
        [NameInMap("ImgUrl")]
        [Validation(Required=false)]
        public string ImgUrl { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RecognizeArea")]
        [Validation(Required=false)]
        public string RecognizeArea { get; set; }

        [NameInMap("ReferArea")]
        [Validation(Required=false)]
        public string ReferArea { get; set; }

    }

}
