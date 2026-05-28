// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class IndexJsonKey : TeaModel {
        /// <summary>
        /// <para>Alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myAlias</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>Case sensitivity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("caseSensitive")]
        [Validation(Required=false)]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// <para>Whether the field contains Chinese characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// <para>Whether to enable statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("doc_value")]
        [Validation(Required=false)]
        public bool? DocValue { get; set; }

        /// <summary>
        /// <para>Delimiter.</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public List<string> Token { get; set; }

        /// <summary>
        /// <para>The data type of the field.</para>
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
