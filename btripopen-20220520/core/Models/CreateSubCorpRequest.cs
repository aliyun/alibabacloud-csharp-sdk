// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CreateSubCorpRequest : TeaModel {
        [NameInMap("outer_corp_id")]
        [Validation(Required=false)]
        public string OuterCorpId { get; set; }

        [NameInMap("outer_corp_name")]
        [Validation(Required=false)]
        public string OuterCorpName { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
