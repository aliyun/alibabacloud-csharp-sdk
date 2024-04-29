// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckCustomConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the check item.
        /// 
        /// > You can call the [ListCheckResult](~~ListCheckResult~~) operation to query the IDs of check items.
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// The custom configuration items of the check item.
        /// </summary>
        [NameInMap("CustomConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigRequestCustomConfigs> CustomConfigs { get; set; }
        public class ChangeCheckCustomConfigRequestCustomConfigs : TeaModel {
            /// <summary>
            /// The name of the custom configuration item. The name of a custom configuration item is unique in a check item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The operation that you want to perform on the custom configuration item. This parameter is required only if you want to delete the custom configuration item. To delete the custom configuration item, set the value to DELETE.
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// The value of the custom configuration item. The value is a string.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The region where the Security Center instance is deployed. Valid values:
        /// 
        /// *   **cn-hangzhou**: International
        /// *   **ap-southeast-1**: Singapore
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RepairConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigRequestRepairConfigs> RepairConfigs { get; set; }
        public class ChangeCheckCustomConfigRequestRepairConfigs : TeaModel {
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
