// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RevertGraphDraftResourceRequest : TeaModel {
        /// <summary>
        /// <para>The draft change ID (the draftChangeId returned by listGraphDraftResources).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>401001</para>
        /// </summary>
        [NameInMap("draftChangeId")]
        [Validation(Required=false)]
        public long? DraftChangeId { get; set; }

        /// <summary>
        /// <para>The knowledge graph name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_graph</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. Pass it explicitly by using --tenant-id in winnexo-cli.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
