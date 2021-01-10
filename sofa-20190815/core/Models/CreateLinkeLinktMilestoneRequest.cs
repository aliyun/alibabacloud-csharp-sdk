// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeLinktMilestoneRequest : TeaModel {
        [NameInMap("ActualEndDate")]
        [Validation(Required=false)]
        public long? ActualEndDate { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExpectEndDate")]
        [Validation(Required=false)]
        public long? ExpectEndDate { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Manager")]
        [Validation(Required=false)]
        public string Manager { get; set; }

        [NameInMap("MilestoneTarget")]
        [Validation(Required=false)]
        public string MilestoneTarget { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
