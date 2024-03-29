// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class RecognizeFaceQualityRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("PicContent")]
        [Validation(Required=false)]
        public string PicContent { get; set; }

        [NameInMap("PicFormat")]
        [Validation(Required=false)]
        public string PicFormat { get; set; }

        [NameInMap("PicUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

    }

}
