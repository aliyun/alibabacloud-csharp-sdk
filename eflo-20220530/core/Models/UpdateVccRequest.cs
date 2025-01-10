// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UpdateVccRequest : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of the Lingjun connection instance. Unit: Mbit/s. Valid values: 1000 to 400000</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the order placed on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20006627643</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Lingjun connection instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-zvp2w222001</para>
        /// </summary>
        [NameInMap("VccId")]
        [Validation(Required=false)]
        public string VccId { get; set; }

        /// <summary>
        /// <para>The name of the Lingjun connection instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-heyuan-backup</para>
        /// </summary>
        [NameInMap("VccName")]
        [Validation(Required=false)]
        public string VccName { get; set; }

    }

}
