// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeLinktRiskRequest : TeaModel {
        [NameInMap("AssignedTo")]
        [Validation(Required=false)]
        public string AssignedTo { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("ExpectedCompletionDate")]
        [Validation(Required=false)]
        public long? ExpectedCompletionDate { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("CcRepeatList")]
        [Validation(Required=false)]
        public List<string> CcRepeatList { get; set; }

    }

}
