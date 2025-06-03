// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class SingleScriptSyncTranslateRequest : TeaModel {
        [NameInMap("sourceDialect")]
        [Validation(Required=false)]
        public string SourceDialect { get; set; }

        [NameInMap("sourceSqlScript")]
        [Validation(Required=false)]
        public string SourceSqlScript { get; set; }

        [NameInMap("tableMapping")]
        [Validation(Required=false)]
        public List<string> TableMapping { get; set; }

        [NameInMap("targetDialect")]
        [Validation(Required=false)]
        public string TargetDialect { get; set; }

    }

}
