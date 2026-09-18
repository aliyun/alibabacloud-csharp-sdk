// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SaveGraphDraftBatchDefineRequest : TeaModel {
        /// <summary>
        /// <para>The list of draft change IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[401001, 401002]</para>
        /// </summary>
        [NameInMap("draftChangeIds")]
        [Validation(Required=false)]
        public List<long?> DraftChangeIds { get; set; }

        /// <summary>
        /// <para>The graph name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_graph</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>The save mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FULL_YAML</para>
        /// </summary>
        [NameInMap("saveMode")]
        [Validation(Required=false)]
        public string SaveMode { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The raw YAML text of the graph schema trimmed by READ permissions, with $ref references retained within the authorized subgraph.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name: crm_graph</para>
        /// </summary>
        [NameInMap("yamlEdit")]
        [Validation(Required=false)]
        public string YamlEdit { get; set; }

    }

}
