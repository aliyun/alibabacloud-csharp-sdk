// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyHeadersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public string CustomHeaders { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;X-Client-IP&quot;:true,&quot;X-True-IP&quot;:true,&quot;Web-Server-Type&quot;:true,&quot;WL-Proxy-Client-IP&quot;:true,&quot;X-Forwarded-Proto&quot;:true}</para>
        /// </summary>
        [NameInMap("EmbeddedHeaders")]
        [Validation(Required=false)]
        public string EmbeddedHeaders { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
