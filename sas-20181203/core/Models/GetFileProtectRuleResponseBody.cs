// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectRuleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectRuleResponseBodyData Data { get; set; }
        public class GetFileProtectRuleResponseBodyData : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public int? AlertLevel { get; set; }

            [NameInMap("FileOps")]
            [Validation(Required=false)]
            public List<string> FileOps { get; set; }

            [NameInMap("FilePaths")]
            [Validation(Required=false)]
            public List<string> FilePaths { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ProcPaths")]
            [Validation(Required=false)]
            public List<string> ProcPaths { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
