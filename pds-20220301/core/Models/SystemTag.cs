// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SystemTag : TeaModel {
        [NameInMap("centric_score")]
        [Validation(Required=false)]
        public float? CentricScore { get; set; }

        [NameInMap("confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parent_name")]
        [Validation(Required=false)]
        public string ParentName { get; set; }

        [NameInMap("tag_level")]
        [Validation(Required=false)]
        public int? TagLevel { get; set; }

    }

}
