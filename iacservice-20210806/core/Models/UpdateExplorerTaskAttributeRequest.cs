// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateExplorerTaskAttributeRequest : TeaModel {
        [NameInMap("autoApply")]
        [Validation(Required=false)]
        public bool? AutoApply { get; set; }

        [NameInMap("explorerTaskName")]
        [Validation(Required=false)]
        public string ExplorerTaskName { get; set; }

        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

    }

}
