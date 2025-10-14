// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class DocBlocksModifyRequest : TeaModel {
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
        public Dictionary<string, object> Element { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public DocBlocksModifyRequestTenantContext TenantContext { get; set; }
        public class DocBlocksModifyRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
