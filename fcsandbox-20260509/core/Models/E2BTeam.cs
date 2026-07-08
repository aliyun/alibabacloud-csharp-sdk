// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class E2BTeam : TeaModel {
        [NameInMap("allowUpdateTeamName")]
        [Validation(Required=false)]
        public bool? AllowUpdateTeamName { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

    }

}
