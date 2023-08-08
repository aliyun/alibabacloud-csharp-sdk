// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20220930.Models
{
    public class StopMeetingTransRequest : TeaModel {
        [NameInMap("MeetingRoleNum")]
        [Validation(Required=false)]
        public int? MeetingRoleNum { get; set; }

        [NameInMap("OnlyRoleSplitResult")]
        [Validation(Required=false)]
        public bool? OnlyRoleSplitResult { get; set; }

    }

}
