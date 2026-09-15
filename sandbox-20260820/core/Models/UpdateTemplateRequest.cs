// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateTemplateRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public PublicUpdateTemplateInput Body { get; set; }

        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
