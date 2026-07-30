// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EntityAddShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of employee, department, or role information.</para>
        /// </summary>
        [NameInMap("entity_d_o_list")]
        [Validation(Required=false)]
        public string EntityDOListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the third-party cost center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340049</para>
        /// </summary>
        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

    }

}
