// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetWebSearchRequest : TeaModel {
        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("history")]
        [Validation(Required=false)]
        public List<GetWebSearchRequestHistory> History { get; set; }
        public class GetWebSearchRequestHistory : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("query_rewrite")]
        [Validation(Required=false)]
        public bool? QueryRewrite { get; set; }

        [NameInMap("top_k")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        [NameInMap("way")]
        [Validation(Required=false)]
        public string Way { get; set; }

    }

}
