// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DeleteHBaseHaDBRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the BDS cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bds-bp14112fd7g52s1****</para>
        /// </summary>
        [NameInMap("BdsId")]
        [Validation(Required=false)]
        public string BdsId { get; set; }

        /// <summary>
        /// <para>The ID of the HA instance. You can call the QueryHBaseHaDB operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-sw2o0l01s4r76****</para>
        /// </summary>
        [NameInMap("HaId")]
        [Validation(Required=false)]
        public string HaId { get; set; }

    }

}
