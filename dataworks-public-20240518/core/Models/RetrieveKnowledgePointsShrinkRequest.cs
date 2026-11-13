// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RetrieveKnowledgePointsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The graph objects to focus the search on. You can specify up to 2 unique objects. The objects must be within the current authorized search scope and do not expand permissions.</para>
        /// </summary>
        [NameInMap("FocusObjects")]
        [Validation(Required=false)]
        public string FocusObjectsShrink { get; set; }

        /// <summary>
        /// <para>A list of 1 to 50 unique knowledge base IDs that restricts the search. If you omit this parameter, the operation discovers knowledge bases within the caller’s authorized scope. If you provide IDs, the operation checks access to each knowledge base and the entire request fails if the caller lacks access to any of them.</para>
        /// </summary>
        [NameInMap("KnowledgeBaseIds")]
        [Validation(Required=false)]
        public string KnowledgeBaseIdsShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of hits across all knowledge bases. Default value: 10. Valid values: 1 to 50. This parameter does not specify the quota for each knowledge base or the page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The natural language question. The length cannot exceed 256 Unicode code points after leading and trailing whitespaces are removed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How is sales revenue calculated, and which tables does it come from?</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
