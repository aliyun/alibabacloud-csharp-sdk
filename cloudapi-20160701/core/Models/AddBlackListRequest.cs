// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class AddBlackListRequest : TeaModel {
        [NameInMap("BlackContent")]
        [Validation(Required=false)]
        public string BlackContent { get; set; }

        [NameInMap("BlackType")]
        [Validation(Required=false)]
        public string BlackType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
