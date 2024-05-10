// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateApplicationRequest : TeaModel {
        /// <summary>
        /// The container application that is protected from being tampered with.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContainerWebDefenseApplicationDTOS")]
        [Validation(Required=false)]
        public List<OperateApplicationRequestContainerWebDefenseApplicationDTOS> ContainerWebDefenseApplicationDTOS { get; set; }
        public class OperateApplicationRequestContainerWebDefenseApplicationDTOS : TeaModel {
            /// <summary>
            /// The ID of the cluster to which the container belongs.
            /// 
            /// >  You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the cluster ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// Specifies whether to apply the configuration to the asset. Valid values:
            /// 
            /// *   **add**: applied
            /// *   **del**: not applied
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// The application ID. If the application is newly added, you do not need to specify this parameter.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The value of the application tag.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
