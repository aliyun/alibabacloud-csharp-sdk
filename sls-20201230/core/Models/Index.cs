// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Index : TeaModel {
        /// <summary>
        /// <para>The field index configuration. The key is the field name and the value is the index configuration for the field. You must specify either this parameter or the \<c>line\\</c> parameter.</para>
        /// </summary>
        [NameInMap("keys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexKey> Keys { get; set; }

        /// <summary>
        /// <para>The full-text index configuration. You must specify either this parameter or the \<c>keys\\</c> parameter.</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public IndexLine Line { get; set; }
        public class IndexLine : TeaModel {
            /// <summary>
            /// <para>Specifies whether the index is case-sensitive.</para>
            /// <list type="bullet">
            /// <item><description><para>true: The index is case-sensitive.</para>
            /// </description></item>
            /// <item><description><para>false (default): The index is not case-sensitive.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("caseSensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }

            /// <summary>
            /// <para>Specifies whether the logs contain Chinese characters.</para>
            /// <list type="bullet">
            /// <item><description><para>true: The logs contain Chinese characters.</para>
            /// </description></item>
            /// <item><description><para>false (default): The logs do not contain Chinese characters.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("chn")]
            [Validation(Required=false)]
            public bool? Chn { get; set; }

            /// <summary>
            /// <para>The list of fields to exclude from the full-text index. This parameter cannot be specified at the same time as \<c>include_keys\\</c>.</para>
            /// </summary>
            [NameInMap("exclude_keys")]
            [Validation(Required=false)]
            public List<string> ExcludeKeys { get; set; }

            /// <summary>
            /// <para>The list of fields to include in the full-text index. This parameter cannot be specified at the same time as \<c>exclude_keys\\</c>.</para>
            /// </summary>
            [NameInMap("include_keys")]
            [Validation(Required=false)]
            public List<string> IncludeKeys { get; set; }

            /// <summary>
            /// <para>The list of delimiters for tokenization. This parameter specifies how the field is tokenized.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public List<string> Token { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable log clustering. If enabled, either the whitelist or the blacklist can be active, but not both.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable log clustering.</para>
        /// </description></item>
        /// <item><description><para>false (default): Do not enable log clustering.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("log_reduce")]
        [Validation(Required=false)]
        public bool? LogReduce { get; set; }

        /// <summary>
        /// <para>The blacklist of fields for log clustering. This parameter is valid only when log clustering is enabled.</para>
        /// </summary>
        [NameInMap("log_reduce_black_list")]
        [Validation(Required=false)]
        public List<string> LogReduceBlackList { get; set; }

        /// <summary>
        /// <para>The whitelist of fields for log clustering. This parameter is valid only when log clustering is enabled.</para>
        /// </summary>
        [NameInMap("log_reduce_white_list")]
        [Validation(Required=false)]
        public List<string> LogReduceWhiteList { get; set; }

        /// <summary>
        /// <para>The default maximum length of a field value in Simple Log Service is 2,048 bytes (2 KB). To change this limit, set the maximum length for a text field. The value must be between 64 and 16,384 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("max_text_len")]
        [Validation(Required=false)]
        public int? MaxTextLen { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the scan index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("scan_index")]
        [Validation(Required=false)]
        public bool? ScanIndex { get; set; }

    }

}
