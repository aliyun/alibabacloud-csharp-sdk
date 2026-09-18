// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateGraphInfoRequest : TeaModel {
        /// <summary>
        /// <para>The business description of the knowledge graph. If not configured, the value is an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer domain knowledge graph</para>
        /// </summary>
        [NameInMap("businessProfile")]
        [Validation(Required=false)]
        public string BusinessProfile { get; set; }

        /// <summary>
        /// <para>The display name of the knowledge graph.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRM Graph</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The name of the knowledge graph.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_graph</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
