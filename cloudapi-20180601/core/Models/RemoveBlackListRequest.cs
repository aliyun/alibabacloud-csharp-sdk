// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class RemoveBlackListRequest : TeaModel {
        [NameInMap("BlackContent")]
        [Validation(Required=false)]
        public string BlackContent { get; set; }

        [NameInMap("BlackType")]
        [Validation(Required=false)]
        public string BlackType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
