// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class IndexKey : TeaModel {
        /// <summary>
        /// <para>The alias of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myAlias</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>Specifies whether the field is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("caseSensitive")]
        [Validation(Required=false)]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// <para>Specifies whether the field contains Chinese characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable statistics for the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("doc_value")]
        [Validation(Required=false)]
        public bool? DocValue { get; set; }

        [NameInMap("embedding")]
        [Validation(Required=false)]
        public string Embedding { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create an index for all text fields in the JSON object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("index_all")]
        [Validation(Required=false)]
        public bool? IndexAll { get; set; }

        /// <summary>
        /// <para>The JSON key.</para>
        /// </summary>
        [NameInMap("json_keys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexJsonKey> JsonKeys { get; set; }

        /// <summary>
        /// <para>The maximum depth.</para>
        /// </summary>
        [NameInMap("max_depth")]
        [Validation(Required=false)]
        public long? MaxDepth { get; set; }

        /// <summary>
        /// <para>The delimiters used for tokenization.</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public List<string> Token { get; set; }

        /// <summary>
        /// <para>The type of the field.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("vector_index")]
        [Validation(Required=false)]
        public string VectorIndex { get; set; }

    }

}
