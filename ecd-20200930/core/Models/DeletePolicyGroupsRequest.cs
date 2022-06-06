// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeletePolicyGroupsRequest : TeaModel {
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public List<string> PolicyGroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
