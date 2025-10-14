// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class DocBlocksModifyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mgokkwiovcq5eu02le8</para>
        /// </summary>
        [NameInMap("BlockId")]
        [Validation(Required=false)]
        public string BlockId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Obva6QBXJwxNZoMOC9bE11Zb8n4qY5Pr</para>
        /// </summary>
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;blockType&quot;:&quot;paragraph&quot;,&quot;paragraph&quot;:{&quot;text&quot;:&quot;ok&quot;}}</para>
        /// </summary>
        [NameInMap("Element")]
        [Validation(Required=false)]
        public string ElementShrink { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
