// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachInstanceRamRoleResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
                [NameInMap("InstanceRamRoleSet")]
                [Validation(Required=false)]
                public List<DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSet> InstanceRamRoleSet { get; set; }
                public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsDetachInstanceRamRoleResultInstanceRamRoleSet : TeaModel {
                    [NameInMap("RamRoleName")]
                    [Validation(Required=false)]
                    public string RamRoleName { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

            }
        };

    }

}
