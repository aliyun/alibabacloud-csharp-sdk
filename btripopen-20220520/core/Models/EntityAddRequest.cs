// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EntityAddRequest : TeaModel {
        [NameInMap("entity_d_o_list")]
        [Validation(Required=false)]
        public List<EntityAddRequestEntityDOList> EntityDOList { get; set; }
        public class EntityAddRequestEntityDOList : TeaModel {
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("user_num")]
            [Validation(Required=false)]
            public int? UserNum { get; set; }

        }

        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
