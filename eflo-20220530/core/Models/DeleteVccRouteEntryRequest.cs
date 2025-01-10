// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class DeleteVccRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>Destination CIDR block</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.199.128/25</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-zvp2w222001</para>
        /// </summary>
        [NameInMap("VccId")]
        [Validation(Required=false)]
        public string VccId { get; set; }

        /// <summary>
        /// <para>The ID of the route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-rte-5cey1sap</para>
        /// </summary>
        [NameInMap("VccRouteEntryId")]
        [Validation(Required=false)]
        public string VccRouteEntryId { get; set; }

    }

}
