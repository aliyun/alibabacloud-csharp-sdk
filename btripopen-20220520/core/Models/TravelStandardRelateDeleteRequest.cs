// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardRelateDeleteRequest : TeaModel {
        [NameInMap("from_group")]
        [Validation(Required=false)]
        public bool? FromGroup { get; set; }

        [NameInMap("remove_list")]
        [Validation(Required=false)]
        public List<TravelStandardRelateDeleteRequestRemoveList> RemoveList { get; set; }
        public class TravelStandardRelateDeleteRequestRemoveList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("rule_id")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
