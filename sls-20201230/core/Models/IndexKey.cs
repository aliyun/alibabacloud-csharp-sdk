// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class IndexKey : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>myAlias</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("doc_value")]
        [Validation(Required=false)]
        public bool? DocValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("index_all")]
        [Validation(Required=false)]
        public bool? IndexAll { get; set; }

        [NameInMap("json_keys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexJsonKey> JsonKeys { get; set; }

        [NameInMap("max_depth")]
        [Validation(Required=false)]
        public long? MaxDepth { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public List<string> Token { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
