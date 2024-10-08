// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteVanityNSRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ns1.example.com,ns2.example.com</para>
        /// </summary>
        [NameInMap("VanityNSList")]
        [Validation(Required=false)]
        public string VanityNSList { get; set; }

    }

}
