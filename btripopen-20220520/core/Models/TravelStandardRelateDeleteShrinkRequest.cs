// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardRelateDeleteShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use the group travel standard. This parameter is optional. If this parameter is not specified, the system determines whether to use the group travel standard based on the unified travel management configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("from_group")]
        [Validation(Required=false)]
        public bool? FromGroup { get; set; }

        /// <summary>
        /// <para>The list of entities to remove from the travel standard.</para>
        /// </summary>
        [NameInMap("remove_list")]
        [Validation(Required=false)]
        public string RemoveListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the travel standard rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6523763</para>
        /// </summary>
        [NameInMap("rule_id")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
