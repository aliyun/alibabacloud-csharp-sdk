// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class RemoveMemberRequest : TeaModel {
        [NameInMap("ConferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("FromUserId")]
        [Validation(Required=false)]
        public string FromUserId { get; set; }

        [NameInMap("ToUserId")]
        [Validation(Required=false)]
        public string ToUserId { get; set; }

    }

}
