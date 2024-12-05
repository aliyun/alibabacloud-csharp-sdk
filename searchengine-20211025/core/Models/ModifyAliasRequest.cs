// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyAliasRequest : TeaModel {
        /// <summary>
        /// <para>alias name</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>index name</para>
        /// 
        /// <b>Example:</b>
        /// <para>index</para>
        /// </summary>
        [NameInMap("index")]
        [Validation(Required=false)]
        public string Index { get; set; }

    }

}
