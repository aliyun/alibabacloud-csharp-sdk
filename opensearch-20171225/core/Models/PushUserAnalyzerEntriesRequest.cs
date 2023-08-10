// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class PushUserAnalyzerEntriesRequest : TeaModel {
        [NameInMap("entries")]
        [Validation(Required=false)]
        public List<PushUserAnalyzerEntriesRequestEntries> Entries { get; set; }
        public class PushUserAnalyzerEntriesRequestEntries : TeaModel {
            [NameInMap("cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("splitEnabled")]
            [Validation(Required=false)]
            public bool? SplitEnabled { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
