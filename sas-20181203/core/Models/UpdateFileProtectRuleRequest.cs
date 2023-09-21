// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectRuleRequest : TeaModel {
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

        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
