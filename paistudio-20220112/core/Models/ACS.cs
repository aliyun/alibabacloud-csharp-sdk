// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ACS : TeaModel {
        /// <summary>
        /// <para>ACS Identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>rq-3kbt2gtimmyw7fgfgothocvh</para>
        /// </summary>
        [NameInMap("ACSQuotaId")]
        [Validation(Required=false)]
        public string ACSQuotaId { get; set; }

        [NameInMap("AssociatedProducts")]
        [Validation(Required=false)]
        public List<string> AssociatedProducts { get; set; }

    }

}
