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
        public Dictionary<string, IndexKey> Keys { get; set; }

        [NameInMap("line")]
        [Validation(Required=false)]
        public IndexLine Line { get; set; }
        public class IndexLine : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("caseSensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public List<string> Token { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("log_reduce")]
        [Validation(Required=false)]
        public bool? LogReduce { get; set; }

        [NameInMap("log_reduce_black_list")]
        [Validation(Required=false)]
        public List<string> LogReduceBlackList { get; set; }

        [NameInMap("log_reduce_white_list")]
        [Validation(Required=false)]
        public List<string> LogReduceWhiteList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("max_text_len")]
        [Validation(Required=false)]
        public int? MaxTextLen { get; set; }

    }

}
