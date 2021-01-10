// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeLinktRiskRequest : TeaModel {
        [NameInMap("AssignedTo")]
        [Validation(Required=false)]
        public string AssignedTo { get; set; }

        [NameInMap("Cc")]
        [Validation(Required=false)]
        public string Cc { get; set; }

        [NameInMap("ExpectedCompletionDate")]
        [Validation(Required=false)]
        public string ExpectedCompletionDate { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
