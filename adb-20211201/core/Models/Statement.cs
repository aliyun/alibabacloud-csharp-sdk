// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class Statement : TeaModel {
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public long? AliyunUid { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CodeState")]
        [Validation(Required=false)]
        public string CodeState { get; set; }

        [NameInMap("CodeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        [NameInMap("HaveRows")]
        [Validation(Required=false)]
        public bool? HaveRows { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public long? SessionId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("StatementId")]
        [Validation(Required=false)]
        public long? StatementId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
