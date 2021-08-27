// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachInstanceRamRoleResponseBody : TeaModel {
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        [NameInMap("DetachInstanceRamRoleResults")]
        [Validation(Required=false)]
        public DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResults DetachInstanceRamRoleResults { get; set; }
        public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResults : TeaModel {
            [NameInMap("DetachInstanceRamRoleResult")]
            [Validation(Required=false)]
            public List<DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResult> DetachInstanceRamRoleResult { get; set; }
            public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResult : TeaModel {
                public string Code { get; set; }
                public string Message { get; set; }
                public string InstanceId { get; set; }
                public bool? Success { get; set; }
                public DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSets InstanceRamRoleSets { get; set; }
                public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSets : TeaModel {
                    [NameInMap("InstanceRamRoleSet")]
                    [Validation(Required=false)]
                    public List<DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSetsInstanceRamRoleSet> InstanceRamRoleSet { get; set; }
                    public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSetsInstanceRamRoleSet : TeaModel {
                        [NameInMap("RamRoleName")]
                        [Validation(Required=false)]
                        public string RamRoleName { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                }
            }
        };

    }

}
