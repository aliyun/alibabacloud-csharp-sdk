// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateTaskAttributeRequest : TeaModel {
        [NameInMap("autoApply")]
        [Validation(Required=false)]
        public bool? AutoApply { get; set; }

        [NameInMap("groupInfo")]
        [Validation(Required=false)]
        public UpdateTaskAttributeRequestGroupInfo GroupInfo { get; set; }
        public class UpdateTaskAttributeRequestGroupInfo : TeaModel {
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("protectionStrategy")]
        [Validation(Required=false)]
        public List<string> ProtectionStrategy { get; set; }

        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("terraformVersion")]
        [Validation(Required=false)]
        public string TerraformVersion { get; set; }

        [NameInMap("triggerStrategy")]
        [Validation(Required=false)]
        public string TriggerStrategy { get; set; }

    }

}
