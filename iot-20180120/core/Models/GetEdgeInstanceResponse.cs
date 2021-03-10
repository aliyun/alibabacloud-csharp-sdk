// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetEdgeInstanceResponseData Data { get; set; }
        public class GetEdgeInstanceResponseData : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=true)]
            public string Tags { get; set; }
            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }
            [NameInMap("Spec")]
            [Validation(Required=true)]
            public int? Spec { get; set; }
            [NameInMap("BizEnable")]
            [Validation(Required=true)]
            public bool? BizEnable { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public string GmtModified { get; set; }
            [NameInMap("RoleArn")]
            [Validation(Required=true)]
            public string RoleArn { get; set; }
            [NameInMap("RoleName")]
            [Validation(Required=true)]
            public string RoleName { get; set; }
            [NameInMap("RoleAttachTime")]
            [Validation(Required=true)]
            public string RoleAttachTime { get; set; }
            [NameInMap("LatestDeploymentStatus")]
            [Validation(Required=true)]
            public int? LatestDeploymentStatus { get; set; }
            [NameInMap("LatestDeploymentType")]
            [Validation(Required=true)]
            public string LatestDeploymentType { get; set; }
            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=true)]
            public long? GmtCreateTimestamp { get; set; }
            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=true)]
            public long? GmtModifiedTimestamp { get; set; }
            [NameInMap("RoleAttachTimestamp")]
            [Validation(Required=true)]
            public long? RoleAttachTimestamp { get; set; }
        };

    }

}
