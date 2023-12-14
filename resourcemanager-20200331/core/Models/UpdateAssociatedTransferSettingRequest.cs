// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAssociatedTransferSettingRequest : TeaModel {
        [NameInMap("RuleSettings")]
        [Validation(Required=false)]
        public List<UpdateAssociatedTransferSettingRequestRuleSettings> RuleSettings { get; set; }
        public class UpdateAssociatedTransferSettingRequestRuleSettings : TeaModel {
            [NameInMap("AssociatedResourceType")]
            [Validation(Required=false)]
            public string AssociatedResourceType { get; set; }

            [NameInMap("AssociatedService")]
            [Validation(Required=false)]
            public string AssociatedService { get; set; }

            [NameInMap("MasterResourceType")]
            [Validation(Required=false)]
            public string MasterResourceType { get; set; }

            [NameInMap("MasterService")]
            [Validation(Required=false)]
            public string MasterService { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
