// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAssociatedTransferSettingResponseBody : TeaModel {
        [NameInMap("AssociatedTransferSetting")]
        [Validation(Required=false)]
        public ListAssociatedTransferSettingResponseBodyAssociatedTransferSetting AssociatedTransferSetting { get; set; }
        public class ListAssociatedTransferSettingResponseBodyAssociatedTransferSetting : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("RuleSettings")]
            [Validation(Required=false)]
            public List<ListAssociatedTransferSettingResponseBodyAssociatedTransferSettingRuleSettings> RuleSettings { get; set; }
            public class ListAssociatedTransferSettingResponseBodyAssociatedTransferSettingRuleSettings : TeaModel {
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

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
