// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PushingSetting : TeaModel {
        [NameInMap("alertActionIds")]
        [Validation(Required=false)]
        public List<string> AlertActionIds { get; set; }

        [NameInMap("restoreActionIds")]
        [Validation(Required=false)]
        public List<string> RestoreActionIds { get; set; }

        [NameInMap("templateUuid")]
        [Validation(Required=false)]
        public string TemplateUuid { get; set; }

    }

}
