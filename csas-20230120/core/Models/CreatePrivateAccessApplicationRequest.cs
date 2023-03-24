// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreatePrivateAccessApplicationRequest : TeaModel {
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<CreatePrivateAccessApplicationRequestPortRanges> PortRanges { get; set; }
        public class CreatePrivateAccessApplicationRequestPortRanges : TeaModel {
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
