// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class PushUserAnalyzerEntriesRequest : TeaModel {
        /// <summary>
        /// The entries of the custom analyzer.
        /// </summary>
        [NameInMap("entries")]
        [Validation(Required=false)]
        public List<PushUserAnalyzerEntriesRequestEntries> Entries { get; set; }
        public class PushUserAnalyzerEntriesRequestEntries : TeaModel {
            /// <summary>
            /// The operation to be performed on the entries.
            /// 
            /// Valid values:
            /// 
            /// *   add
            /// *   delete
            /// </summary>
            [NameInMap("cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            /// <summary>
            /// The key to be used to query entries.
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// Specifies whether to further analyze the terms that are generated after the search query is analyzed.
            /// 
            /// Default value: true.
            /// </summary>
            [NameInMap("splitEnabled")]
            [Validation(Required=false)]
            public bool? SplitEnabled { get; set; }

            /// <summary>
            /// The analysis result.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to perform a dry run. This parameter is only used to check whether the data source is valid. Valid values: true and false.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
