// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class BindMaterialRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("LegalNoticeKey")]
        [Validation(Required=false)]
        public string LegalNoticeKey { get; set; }

        [NameInMap("LoaOssKey")]
        [Validation(Required=false)]
        public string LoaOssKey { get; set; }

        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

    }

}
