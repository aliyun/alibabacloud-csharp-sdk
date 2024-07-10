// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class Revision : TeaModel {
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RevisionConfig")]
        [Validation(Required=false)]
        public RevisionConfig RevisionConfig { get; set; }

        [NameInMap("RevisionId")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public float? Weight { get; set; }

    }

}
