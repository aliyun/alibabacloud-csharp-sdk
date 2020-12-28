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
        public List<DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResults> DetachInstanceRamRoleResults { get; set; }
        public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResults : TeaModel {
            [NameInMap("InstanceRamRoleSets")]
            [Validation(Required=false)]
            public List<DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsInstanceRamRoleSets> InstanceRamRoleSets { get; set; }
            public class DetachInstanceRamRoleResponseBodyDetachInstanceRamRoleResultsInstanceRamRoleSets : TeaModel {
                [NameInMap("RamRoleName")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
