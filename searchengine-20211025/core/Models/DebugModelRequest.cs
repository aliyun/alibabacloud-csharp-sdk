// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class DebugModelRequest : TeaModel {
        /// <summary>
        /// <para>The input of the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform an online query. Set this parameter to true to use the search configuration. Set this parameter to false to use the build configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isOnline")]
        [Validation(Required=false)]
        public string IsOnline { get; set; }

    }

}
