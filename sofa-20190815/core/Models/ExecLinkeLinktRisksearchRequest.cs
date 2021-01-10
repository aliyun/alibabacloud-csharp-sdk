// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeLinktRisksearchRequest : TeaModel {
        [NameInMap("AssignedTo")]
        [Validation(Required=false)]
        public string AssignedTo { get; set; }

        [NameInMap("Finished")]
        [Validation(Required=false)]
        public string Finished { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public string Start { get; set; }

    }

}
