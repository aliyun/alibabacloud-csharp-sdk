// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeLinktIterationRequest : TeaModel {
        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public long? BeginDate { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("IterationSign")]
        [Validation(Required=false)]
        public string IterationSign { get; set; }

        [NameInMap("Locked")]
        [Validation(Required=false)]
        public bool? Locked { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
