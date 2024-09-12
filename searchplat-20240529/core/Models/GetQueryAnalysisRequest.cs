// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetQueryAnalysisRequest : TeaModel {
        [NameInMap("functions")]
        [Validation(Required=false)]
        public List<GetQueryAnalysisRequestFunctions> Functions { get; set; }
        public class GetQueryAnalysisRequestFunctions : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameters { get; set; }

        }

        [NameInMap("history")]
        [Validation(Required=false)]
        public List<GetQueryAnalysisRequestHistory> History { get; set; }
        public class GetQueryAnalysisRequestHistory : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
