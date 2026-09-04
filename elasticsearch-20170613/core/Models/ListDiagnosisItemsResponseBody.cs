// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDiagnosisItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDiagnosisItemsResponseBodyResult> Result { get; set; }
        public class ListDiagnosisItemsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether billable tokens are consumed. The value is true when level is ADVANCED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("billable")]
            [Validation(Required=false)]
            public bool? Billable { get; set; }

            /// <summary>
            /// <para>The category code. You can use this value to group diagnostic items by category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLUSTER_HEALTH</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The diagnostic item description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Diagnoses whether data write operations are backlogged in the cluster. When data write operations are backlogged, BulkReject exceptions occur, which may cause data loss and severe system resource consumption</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster API is accessed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("esApiRequired")]
            [Validation(Required=false)]
            public bool? EsApiRequired { get; set; }

            /// <summary>
            /// <para>The diagnostic item identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterBulkRejectDiagnostic</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The diagnostic item level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BASIC: basic inspection item (free).</description></item>
            /// <item><description>ADVANCED: advanced inspection item (consumes billable tokens).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The diagnostic item name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Index Write BulkReject Diagnostics</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The sort order number for display.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sortOrder")]
            [Validation(Required=false)]
            public int? SortOrder { get; set; }

            /// <summary>
            /// <para>The supported execution modes. Basic items support RULE and AGENT. Advanced items support only AGENT.</para>
            /// </summary>
            [NameInMap("supportedModes")]
            [Validation(Required=false)]
            public List<string> SupportedModes { get; set; }

        }

    }

}
