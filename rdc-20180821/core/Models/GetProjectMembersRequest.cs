// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class GetProjectMembersRequest : TeaModel {
        [NameInMap("CorpIdentifier")]
        [Validation(Required=false)]
        public string CorpIdentifier { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public int? ProjectId { get; set; }

        [NameInMap("StaffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

    }

}
