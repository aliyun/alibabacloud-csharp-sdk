// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EntityDeleteShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all members.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("del_all")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        /// <summary>
        /// <para>The list of members to delete. This parameter is not required when delAll is set to true.</para>
        /// </summary>
        [NameInMap("entity_d_o_list")]
        [Validation(Required=false)]
        public string EntityDOListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the third-party cost center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

    }

}
