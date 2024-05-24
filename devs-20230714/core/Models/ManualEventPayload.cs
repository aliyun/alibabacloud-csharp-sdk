// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ManualEventPayload : TeaModel {
        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("commitID")]
        [Validation(Required=false)]
        public string CommitID { get; set; }

        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        [NameInMap("templateConfig")]
        [Validation(Required=false)]
        public TemplateConfig TemplateConfig { get; set; }

    }

}
