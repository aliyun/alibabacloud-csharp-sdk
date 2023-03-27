// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachInstanceRamRoleResponseBody : TeaModel {
        /// <summary>
        /// Details about the results of detaching the instance RAM role from the instances.
        /// </summary>
        [NameInMap("DetachInstanceRamRoleResults")]
        [Validation(Required=false)]
        public DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResults DetachInstanceRamRoleResults { get; set; }
        public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResults : TeaModel {
            [NameInMap("DetachInstanceRamRoleResult")]
            [Validation(Required=false)]
            public List<DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResult> DetachInstanceRamRoleResult { get; set; }
            public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResult : TeaModel {
                /// <summary>
                /// The code that indicates whether the instance RAM role was detached. If 200 is returned, the instance RAM role was detached. If any other value is returned, the instance RAM role failed to be detached. For more information, see the "Error codes" section.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The ID of the instance from which you attempted to detach the instance RAM role.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The details about the instance RAM roles of the instances.
                /// </summary>
                [NameInMap("InstanceRamRoleSets")]
                [Validation(Required=false)]
                public DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSets InstanceRamRoleSets { get; set; }
                public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSets : TeaModel {
                    [NameInMap("InstanceRamRoleSet")]
                    [Validation(Required=false)]
                    public List<DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSetsInstanceRamRoleSet> InstanceRamRoleSet { get; set; }
                    public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSetsInstanceRamRoleSet : TeaModel {
                        /// <summary>
                        /// The ID of the instance from which the RAM role was detached.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The name of the instance RAM role.
                        /// </summary>
                        [NameInMap("RamRoleName")]
                        [Validation(Required=false)]
                        public string RamRoleName { get; set; }

                    }

                }

                /// <summary>
                /// The message that indicates whether the instance RAM role was detached. If success is returned, the instance RAM role was detached. If any other value is returned, the instance RAM role failed to be detached. For more information, see the "Error codes" section.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Indicates whether the RAM role was detached.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// The number of the instances from which the RAM role failed to be detached.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the instances from which you detached the RAM role.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
