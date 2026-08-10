// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SearchKgBySemanticRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The search command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SearchCommand")]
        [Validation(Required=false)]
        public SearchKgBySemanticRequestSearchCommand SearchCommand { get; set; }
        public class SearchKgBySemanticRequestSearchCommand : TeaModel {
            /// <summary>
            /// <para>The entity type codes used for filtering. If this parameter is not specified, all entity types are searched.</para>
            /// </summary>
            [NameInMap("EntityTypeCodes")]
            [Validation(Required=false)]
            public List<string> EntityTypeCodes { get; set; }

            /// <summary>
            /// <para>The minimum similarity threshold. Valid values: 0.0 to 1.0. Default value: 0.0 (no filtering). This parameter takes effect only for the semantic search path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("MinSimilarity")]
            [Validation(Required=false)]
            public float? MinSimilarity { get; set; }

            /// <summary>
            /// <para>The property code for semantic search. If this parameter is not specified, all properties with semantic search enabled are searched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("PropertyCode")]
            [Validation(Required=false)]
            public string PropertyCode { get; set; }

            /// <summary>
            /// <para>The natural language query text. The value can be 0 to 500 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Query students in Beijing</para>
            /// </summary>
            [NameInMap("QueryText")]
            [Validation(Required=false)]
            public string QueryText { get; set; }

            /// <summary>
            /// <para>The maximum number of results to return. Default value: 20. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TopK")]
            [Validation(Required=false)]
            public int? TopK { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1d4559a4db044158305e2d89bccf81f</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
