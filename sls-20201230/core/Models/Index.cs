// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Index : TeaModel {
        /// <summary>
        /// <para>The configurations of field indexes. A field index is a key-value pair in which the key specifies the name of the field and the value specifies the index configuration of the field. You must specify at least one of the following parameters: line and keys.</para>
        /// </summary>
        [NameInMap("keys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexKey> Keys { get; set; }

        /// <summary>
        /// <para>The configurations of full-text indexes. You must specify at least one of the following parameters: line and keys.</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public IndexLine Line { get; set; }
        public class IndexLine : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable case sensitivity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("caseSensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }

            /// <summary>
            /// <para>Specifies whether the field contains Chinese characters. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("chn")]
            [Validation(Required=false)]
            public bool? Chn { get; set; }

            /// <summary>
            /// <para>The excluded fields. You cannot specify both include_keys and exclude_keys.</para>
            /// </summary>
            [NameInMap("exclude_keys")]
            [Validation(Required=false)]
            public List<string> ExcludeKeys { get; set; }

            /// <summary>
            /// <para>The included fields. You cannot specify both include_keys and exclude_keys.</para>
            /// </summary>
            [NameInMap("include_keys")]
            [Validation(Required=false)]
            public List<string> IncludeKeys { get; set; }

            /// <summary>
            /// <para>The delimiters. You can specify a delimiter to delimit the content of a field value.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public List<string> Token { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the LogReduce feature. After you enable the LogReduce feature, either the whitelist or blacklist takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("log_reduce")]
        [Validation(Required=false)]
        public bool? LogReduce { get; set; }

        /// <summary>
        /// <para>The blacklist of fields that are used to cluster logs. This parameter takes effect only when the LogReduce feature is enabled.</para>
        /// </summary>
        [NameInMap("log_reduce_black_list")]
        [Validation(Required=false)]
        public List<string> LogReduceBlackList { get; set; }

        /// <summary>
        /// <para>The whitelist of fields that are used to cluster logs. This parameter takes effect only when the LogReduce feature is enabled.</para>
        /// </summary>
        [NameInMap("log_reduce_white_list")]
        [Validation(Required=false)]
        public List<string> LogReduceWhiteList { get; set; }

        /// <summary>
        /// <para>The maximum length of a field value that can be retained. Default value: 2048. Unit: bytes. The default value is equal to 2 KB. You can change the value of this parameter. Valid values: 64 to 16384.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("max_text_len")]
        [Validation(Required=false)]
        public int? MaxTextLen { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("scan_index")]
        [Validation(Required=false)]
        public bool? ScanIndex { get; set; }

    }

}
