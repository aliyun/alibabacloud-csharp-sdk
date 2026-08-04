// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ACS : TeaModel {
        /// <summary>
        /// <para>ACS resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rq-3kbt2gtimmyw7fgfgothocvh</para>
        /// </summary>
        [NameInMap("ACSQuotaId")]
        [Validation(Required=false)]
        public string ACSQuotaId { get; set; }

        /// <summary>
        /// <para>Product codes that can use the ACS Quota.</para>
        /// <para>Constraints:<br>You can select multiple sub-products, but some sub-products are mutually exclusive. The following combinations can be selected simultaneously:  </para>
        /// <list type="bullet">
        /// <item><description>PAI-DLC, PAI-DSW  </description></item>
        /// <item><description>PAI-EAS</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AssociatedProducts")]
        [Validation(Required=false)]
        public List<string> AssociatedProducts { get; set; }

    }

}
