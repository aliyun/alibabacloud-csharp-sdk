// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AttachInstanceRamRoleResponseBody : TeaModel {
        /// <summary>
        /// Details about the results of attaching the instance RAM role.
        /// </summary>
        [NameInMap("AttachInstanceRamRoleResults")]
        [Validation(Required=false)]
        public AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResults AttachInstanceRamRoleResults { get; set; }
        public class AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResults : TeaModel {
            [NameInMap("AttachInstanceRamRoleResult")]
            [Validation(Required=false)]
            public List<AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResultsAttachInstanceRamRoleResult> AttachInstanceRamRoleResult { get; set; }
            public class AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResultsAttachInstanceRamRoleResult : TeaModel {
                /// <summary>
                /// Indicates whether the instance RAM role was attached. If the instance RAM role was attached, 200 is returned. If the instance RAM role failed to be attached, any other value is returned. For more information, see the "Error codes" section.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// Indicates whether the instance RAM role was attached. If the instance RAM role was attached, success is returned. If the instance RAM role failed to be attached, any other value is returned. For more information, see the "Error codes" section.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Indicates whether the instance RAM role was attached.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// The number of instances to which the instance RAM role failed to be attached.
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// The name of the instance RAM role.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of instances to which you attempted to attach the instance RAM role.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
