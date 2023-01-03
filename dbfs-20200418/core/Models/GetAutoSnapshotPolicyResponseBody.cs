// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class GetAutoSnapshotPolicyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoSnapshotPolicyResponseBodyData Data { get; set; }
        public class GetAutoSnapshotPolicyResponseBodyData : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("AppliedDbfsNumber")]
            [Validation(Required=false)]
            public int? AppliedDbfsNumber { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RepeatWeekdays")]
            [Validation(Required=false)]
            public List<string> RepeatWeekdays { get; set; }

            [NameInMap("RetentionDays")]
            [Validation(Required=false)]
            public int? RetentionDays { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

            [NameInMap("TimePoints")]
            [Validation(Required=false)]
            public List<string> TimePoints { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
