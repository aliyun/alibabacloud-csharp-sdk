// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Index : TeaModel {
        [NameInMap("keys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexKeysValue> Keys { get; set; }

        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        [NameInMap("line")]
        [Validation(Required=false)]
        public IndexLine Line { get; set; }
        public class IndexLine : TeaModel {
            [NameInMap("caseSensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }

            [NameInMap("chn")]
            [Validation(Required=false)]
            public bool? Chn { get; set; }

            [NameInMap("exclude_keys")]
            [Validation(Required=false)]
            public List<string> ExcludeKeys { get; set; }

            [NameInMap("include_keys")]
            [Validation(Required=false)]
            public List<string> IncludeKeys { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public List<string> Token { get; set; }

        }

        [NameInMap("log_reduce")]
        [Validation(Required=false)]
        public bool? LogReduce { get; set; }

        [NameInMap("log_reduce_black_list")]
        [Validation(Required=false)]
        public List<string> LogReduceBlackList { get; set; }

        [NameInMap("log_reduce_white_list")]
        [Validation(Required=false)]
        public List<string> LogReduceWhiteList { get; set; }

        [NameInMap("max_text_len")]
        [Validation(Required=false)]
        public int? MaxTextLen { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
