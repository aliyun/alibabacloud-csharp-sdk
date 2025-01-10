// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetVccRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Lingjun Connection ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-zvp2w222001</para>
        /// </summary>
        [NameInMap("VccId")]
        [Validation(Required=false)]
        public string VccId { get; set; }

        /// <summary>
        /// <para>The ID of the route entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-rte-31ocvdhq</para>
        /// </summary>
        [NameInMap("VccRouteEntryId")]
        [Validation(Required=false)]
        public string VccRouteEntryId { get; set; }

    }

}
