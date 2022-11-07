// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemRecordRequest : TeaModel {
        [NameInMap("actualTime")]
        [Validation(Required=false)]
        public string ActualTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("gmtEnd")]
        [Validation(Required=false)]
        public string GmtEnd { get; set; }

        [NameInMap("gmtStart")]
        [Validation(Required=false)]
        public string GmtStart { get; set; }

        [NameInMap("recordUserIdentifier")]
        [Validation(Required=false)]
        public string RecordUserIdentifier { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("workitemIdentifier")]
        [Validation(Required=false)]
        public string WorkitemIdentifier { get; set; }

    }

}
