// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAssociatedTransferSettingResponseBody : TeaModel {
        /// <summary>
        /// The settings of the Transfer Associated Resources feature.
        /// </summary>
        [NameInMap("AssociatedTransferSetting")]
        [Validation(Required=false)]
        public ListAssociatedTransferSettingResponseBodyAssociatedTransferSetting AssociatedTransferSetting { get; set; }
        public class ListAssociatedTransferSettingResponseBodyAssociatedTransferSetting : TeaModel {
            /// <summary>
            /// The settings of the Transfer Associated Resources feature.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("EnableExistingResourcesTransfer")]
            [Validation(Required=false)]
            public string EnableExistingResourcesTransfer { get; set; }

            /// <summary>
            /// The settings of the transfer rules.
            /// </summary>
            [NameInMap("RuleSettings")]
            [Validation(Required=false)]
            public List<ListAssociatedTransferSettingResponseBodyAssociatedTransferSettingRuleSettings> RuleSettings { get; set; }
            public class ListAssociatedTransferSettingResponseBodyAssociatedTransferSettingRuleSettings : TeaModel {
                /// <summary>
                /// The type of the associated resource.
                /// </summary>
                [NameInMap("AssociatedResourceType")]
                [Validation(Required=false)]
                public string AssociatedResourceType { get; set; }

                /// <summary>
                /// The service code of the associated resource.
                /// </summary>
                [NameInMap("AssociatedService")]
                [Validation(Required=false)]
                public string AssociatedService { get; set; }

                /// <summary>
                /// The type of the primary resource.
                /// </summary>
                [NameInMap("MasterResourceType")]
                [Validation(Required=false)]
                public string MasterResourceType { get; set; }

                /// <summary>
                /// The service code of the primary resource.
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

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
