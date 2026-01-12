// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class SaveSourceRequest : TeaModel {
        [NameInMap("ChangeStatus")]
        [Validation(Required=false)]
        public bool? ChangeStatus { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("NeedCheck")]
        [Validation(Required=false)]
        public bool? NeedCheck { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
