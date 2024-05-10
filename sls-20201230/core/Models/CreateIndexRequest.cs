// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateIndexRequest : TeaModel {
        /// <summary>
        /// The configuration of field indexes. A field index is a key-value pair in which the key specifies the name of the field and the value specifies the index configuration of the field. You must specify this parameter, the line parameter, or both parameters. For more information, see Example.
        /// </summary>
        [NameInMap("keys")]
        [Validation(Required=false)]
        public Dictionary<string, KeysValue> Keys { get; set; }

        /// <summary>
        /// The configuration of full-text indexes. You must specify this parameter, the keys parameter, or both parameters. For more information, see Example.
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public CreateIndexRequestLine Line { get; set; }
        public class CreateIndexRequestLine : TeaModel {
            /// <summary>
            /// Specifies whether to enable case sensitivity. Valid values:
            /// 
            /// *   true
            /// *   false (default)
            /// </summary>
            [NameInMap("caseSensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }

            /// <summary>
            /// Specifies whether to include Chinese characters. Valid values:
            /// 
            /// *   true
            /// *   false (default)
            /// </summary>
            [NameInMap("chn")]
            [Validation(Required=false)]
            public bool? Chn { get; set; }

            /// <summary>
            /// The excluded fields. You cannot specify both include_keys and exclude_keys.
            /// </summary>
            [NameInMap("exclude_keys")]
            [Validation(Required=false)]
            public List<string> ExcludeKeys { get; set; }

            /// <summary>
            /// The included fields. You cannot specify both include_keys and exclude_keys.
            /// </summary>
            [NameInMap("include_keys")]
            [Validation(Required=false)]
            public List<string> IncludeKeys { get; set; }

            /// <summary>
            /// The delimiters. You can specify a delimiter to delimit the content of a field value. For more information about delimiters, see Example.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public List<string> Token { get; set; }

        }

        /// <summary>
        /// Specifies whether to turn on LogReduce. After you turn on LogReduce, either the whitelist or blacklist takes effect.
        /// </summary>
        [NameInMap("log_reduce")]
        [Validation(Required=false)]
        public bool? LogReduce { get; set; }

        /// <summary>
        /// The fields in the blacklist that you want to use to cluster logs.
        /// </summary>
        [NameInMap("log_reduce_black_list")]
        [Validation(Required=false)]
        public List<string> LogReduceBlackList { get; set; }

        /// <summary>
        /// The fields in the whitelist that you want to use to cluster logs.
        /// </summary>
        [NameInMap("log_reduce_white_list")]
        [Validation(Required=false)]
        public List<string> LogReduceWhiteList { get; set; }

        /// <summary>
        /// The maximum length of a field value that can be retained. Default value: 2048. Unit: bytes. The default value is equal to 2 KB. You can change the value of max_text_len. Valid values: 64 to 16384.
        /// </summary>
        [NameInMap("max_text_len")]
        [Validation(Required=false)]
        public int? MaxTextLen { get; set; }

        /// <summary>
        /// The retention period of logs. Unit: days. Valid values: 7, 30, and 90.
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
