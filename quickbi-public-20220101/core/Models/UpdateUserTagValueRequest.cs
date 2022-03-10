// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserTagValueRequest : TeaModel {
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        [NameInMap("TagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
