// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardRelateAddShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of entities to add to the travel standard. The maximum number of entities per request is 500.</para>
        /// </summary>
        [NameInMap("add_list")]
        [Validation(Required=false)]
        public string AddListShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the group travel standard. This parameter is optional. If not specified, the system determines whether to use the group travel standard based on the unified travel management configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("from_group")]
        [Validation(Required=false)]
        public bool? FromGroup { get; set; }

        /// <summary>
        /// <para>The ID of the travel standard rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6516571</para>
        /// </summary>
        [NameInMap("rule_id")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
