// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateTeamInput : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("plan")]
        [Validation(Required=false)]
        public string Plan { get; set; }

        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

    }

}
