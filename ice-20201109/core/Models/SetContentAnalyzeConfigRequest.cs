// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetContentAnalyzeConfigRequest : TeaModel {
        [NameInMap("Auto")]
        [Validation(Required=false)]
        public bool? Auto { get; set; }

        [NameInMap("SaveType")]
        [Validation(Required=false)]
        public string SaveType { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
