// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class KnowledgeSubJobInfoVO : TeaModel {
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubJobId")]
        [Validation(Required=false)]
        public int? SubJobId { get; set; }

    }

}
