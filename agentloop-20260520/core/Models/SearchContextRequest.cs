// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class SearchContextRequest : TeaModel {
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filter { get; set; }

        [NameInMap("formatted")]
        [Validation(Required=false)]
        public bool? Formatted { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("retrievalOption")]
        [Validation(Required=false)]
        public string RetrievalOption { get; set; }

        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
