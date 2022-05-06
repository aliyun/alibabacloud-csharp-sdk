// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DetachGadInstanceMemberRequest : TeaModel {
        [NameInMap("GadInstanceName")]
        [Validation(Required=false)]
        public string GadInstanceName { get; set; }

        [NameInMap("MemberInstanceName")]
        [Validation(Required=false)]
        public string MemberInstanceName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
