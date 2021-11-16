// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetProjectDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProjectDetailResponseBodyData Data { get; set; }
        public class GetProjectDetailResponseBodyData : TeaModel {
            [NameInMap("DefaultDiResourceGroupIdentifier")]
            [Validation(Required=false)]
            public string DefaultDiResourceGroupIdentifier { get; set; }
            [NameInMap("DevelopmentType")]
            [Validation(Required=false)]
            public int? DevelopmentType { get; set; }
            [NameInMap("EnvTypes")]
            [Validation(Required=false)]
            public List<string> EnvTypes { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("IsAllowDownload")]
            [Validation(Required=false)]
            public int? IsAllowDownload { get; set; }
            [NameInMap("ProjectDescription")]
            [Validation(Required=false)]
            public string ProjectDescription { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public int? ProjectId { get; set; }
            [NameInMap("ProjectIdentifier")]
            [Validation(Required=false)]
            public string ProjectIdentifier { get; set; }
            [NameInMap("ProjectMode")]
            [Validation(Required=false)]
            public int? ProjectMode { get; set; }
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }
            [NameInMap("ProjectOwnerBaseId")]
            [Validation(Required=false)]
            public string ProjectOwnerBaseId { get; set; }
            [NameInMap("ProtectedMode")]
            [Validation(Required=false)]
            public int? ProtectedMode { get; set; }
            [NameInMap("ResidentArea")]
            [Validation(Required=false)]
            public string ResidentArea { get; set; }
            [NameInMap("SchedulerMaxRetryTimes")]
            [Validation(Required=false)]
            public int? SchedulerMaxRetryTimes { get; set; }
            [NameInMap("SchedulerRetryInterval")]
            [Validation(Required=false)]
            public int? SchedulerRetryInterval { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
