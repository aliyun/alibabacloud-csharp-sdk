// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedQueryContext : TeaModel {
        [NameInMap("engineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("originalQuery")]
        [Validation(Required=false)]
        public UnifiedOriginalQuery OriginalQuery { get; set; }

        [NameInMap("rewrite")]
        [Validation(Required=false)]
        public UnifiedRewrite Rewrite { get; set; }

    }

}
