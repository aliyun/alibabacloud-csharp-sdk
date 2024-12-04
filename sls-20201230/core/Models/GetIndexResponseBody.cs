// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetIndexResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("index_mode")]
        [Validation(Required=false)]
        public string IndexMode { get; set; }

        /// <summary>
        /// <para>The configurations of field indexes. A field index is in the key-value format in which the key specifies the name of the field and the value specifies the index configuration of the field.</para>
        /// </summary>
        [NameInMap("keys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexKey> Keys { get; set; }

        /// <summary>
        /// <para>The time when the index configurations were last updated. The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1524155379</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// <para>The configurations of full-text indexes.</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public GetIndexResponseBodyLine Line { get; set; }
        public class GetIndexResponseBodyLine : TeaModel {
            /// <summary>
            /// <para>Indicates whether case sensitivity is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("caseSensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }

            /// <summary>
            /// <para>Indicates whether Chinese characters are included. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("chn")]
            [Validation(Required=false)]
            public bool? Chn { get; set; }

            /// <summary>
            /// <para>The excluded fields.</para>
            /// </summary>
            [NameInMap("exclude_keys")]
            [Validation(Required=false)]
            public List<string> ExcludeKeys { get; set; }

            /// <summary>
            /// <para>The included fields.</para>
            /// </summary>
            [NameInMap("include_keys")]
            [Validation(Required=false)]
            public List<string> IncludeKeys { get; set; }

            /// <summary>
            /// <para>The delimiters.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public List<string> Token { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the log clustering feature is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("log_reduce")]
        [Validation(Required=false)]
        public bool? LogReduce { get; set; }

        /// <summary>
        /// <para>The fields in the blacklist that are used to cluster logs. This parameter is valid only if the log clustering feature is enabled.</para>
        /// </summary>
        [NameInMap("log_reduce_black_list")]
        [Validation(Required=false)]
        public List<string> LogReduceBlackList { get; set; }

        /// <summary>
        /// <para>The fields in the whitelist that are used to cluster logs. This parameter is valid only if the log clustering feature is enabled.</para>
        /// </summary>
        [NameInMap("log_reduce_white_list")]
        [Validation(Required=false)]
        public List<string> LogReduceWhiteList { get; set; }

        /// <summary>
        /// <para>The maximum length of a field value that can be retained. Default value: 2048. Unit: bytes. The default value is equal to 2 KB. You can change the value of the max_text_len parameter. Valid values: 64 to 16384. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("max_text_len")]
        [Validation(Required=false)]
        public int? MaxTextLen { get; set; }

        /// <summary>
        /// <para>The storage type. The value is fixed as pg.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg</para>
        /// </summary>
        [NameInMap("storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

        /// <summary>
        /// <para>The lifecycle of the index file. Valid values: 7, 30, and 90. Unit: day.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
