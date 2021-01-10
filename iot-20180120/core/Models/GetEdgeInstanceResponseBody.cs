// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEdgeInstanceResponseBodyData Data { get; set; }
        public class GetEdgeInstanceResponseBodyData : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }
            [NameInMap("RoleAttachTime")]
            [Validation(Required=false)]
            public string RoleAttachTime { get; set; }
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public int? Spec { get; set; }
            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifiedTimestamp { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("RoleAttachTimestamp")]
            [Validation(Required=false)]
            public long? RoleAttachTimestamp { get; set; }
            [NameInMap("LatestDeploymentType")]
            [Validation(Required=false)]
            public string LatestDeploymentType { get; set; }
            [NameInMap("LatestDeploymentStatus")]
            [Validation(Required=false)]
            public int? LatestDeploymentStatus { get; set; }
            [NameInMap("BizEnable")]
            [Validation(Required=false)]
            public bool? BizEnable { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
