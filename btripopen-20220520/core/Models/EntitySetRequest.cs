// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EntitySetRequest : TeaModel {
        [NameInMap("entity_d_o_list")]
        [Validation(Required=false)]
        public List<EntitySetRequestEntityDOList> EntityDOList { get; set; }
        public class EntitySetRequestEntityDOList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

    }

}
