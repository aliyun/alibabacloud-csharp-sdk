// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class KnowledgeJobInfoVO : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public int? JobId { get; set; }

        [NameInMap("KnowledgeCnt")]
        [Validation(Required=false)]
        public int? KnowledgeCnt { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        [NameInMap("ShowJobId")]
        [Validation(Required=false)]
        public string ShowJobId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Supplement")]
        [Validation(Required=false)]
        public string Supplement { get; set; }

        [NameInMap("TableCnt")]
        [Validation(Required=false)]
        public int? TableCnt { get; set; }

    }

}
