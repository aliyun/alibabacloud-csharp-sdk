// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAssociatedTransferSettingRequest : TeaModel {
        [NameInMap("EnableExistingResourcesTransfer")]
        [Validation(Required=false)]
        public string EnableExistingResourcesTransfer { get; set; }

        /// <summary>
        /// The settings of the transfer rules.
        /// </summary>
        [NameInMap("RuleSettings")]
        [Validation(Required=false)]
        public List<UpdateAssociatedTransferSettingRequestRuleSettings> RuleSettings { get; set; }
        public class UpdateAssociatedTransferSettingRequestRuleSettings : TeaModel {
            /// <summary>
            /// The type of the associated resource.
            /// 
            /// You can obtain the resource type from the **Resource type** column in [Services that work with Resource Group](~~94479~~).
            /// </summary>
            [NameInMap("AssociatedResourceType")]
            [Validation(Required=false)]
            public string AssociatedResourceType { get; set; }

            /// <summary>
            /// The service code of the associated resource.
            /// 
            /// You can obtain the service code from the **Service code** column in [Services that work with Resource Group](~~94479~~).
            /// </summary>
            [NameInMap("AssociatedService")]
            [Validation(Required=false)]
            public string AssociatedService { get; set; }

            /// <summary>
            /// The type of the primary resource.
            /// 
            /// You can obtain the resource type from the **Resource type** column in [Services that work with Resource Group](~~94479~~).
            /// </summary>
            [NameInMap("MasterResourceType")]
            [Validation(Required=false)]
            public string MasterResourceType { get; set; }

            /// <summary>
            /// The service code of the primary resource.
            /// 
            /// You can obtain the service code from the **Service code** column in [Services that work with Resource Group](~~94479~~).
            /// </summary>
            [NameInMap("MasterService")]
            [Validation(Required=false)]
            public string MasterService { get; set; }

            /// <summary>
            /// The status of the Transfer Associated Resources feature. Valid values:
            /// 
            /// - Enable: enabled
            /// - Disable: disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
