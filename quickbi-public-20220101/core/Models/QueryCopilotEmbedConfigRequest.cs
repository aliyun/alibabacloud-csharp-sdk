// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryCopilotEmbedConfigRequest : TeaModel {
        /// <summary>
        /// <para>Name of the embedded configuration module, supports fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06-ELive</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

    }

}
