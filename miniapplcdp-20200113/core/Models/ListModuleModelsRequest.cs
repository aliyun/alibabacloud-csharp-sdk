// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class ListModuleModelsRequest : TeaModel {
        [NameInMap("ModuleList")]
        [Validation(Required=false)]
        public string ModuleList { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SubTypes")]
        [Validation(Required=false)]
        public string SubTypes { get; set; }

        [NameInMap("WithContent")]
        [Validation(Required=false)]
        public bool? WithContent { get; set; }

    }

}
