// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateAliasRequest : TeaModel {
        /// <summary>
        /// <para>The alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The associated index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index</para>
        /// </summary>
        [NameInMap("index")]
        [Validation(Required=false)]
        public string Index { get; set; }

        /// <summary>
        /// <para>Specifies whether the new version of the console page is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("newMode")]
        [Validation(Required=false)]
        public bool? NewMode { get; set; }

    }

}
