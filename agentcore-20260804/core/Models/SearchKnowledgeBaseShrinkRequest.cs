// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class SearchKnowledgeBaseShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The search text and the search configuration overrides for the current request. If the mode, count, fusion, and reranking parameters are omitted, the knowledge base configuration is used. If the knowledge base is not configured, the system default values specified in each field description are used. If metadataFilter is omitted, no metadata filtering is applied.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

    }

}
