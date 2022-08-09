// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EntityDeleteShrinkRequest : TeaModel {
        [NameInMap("del_all")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        [NameInMap("entity_d_o_list")]
        [Validation(Required=false)]
        public string EntityDOListShrink { get; set; }

        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

    }

}
