// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetWebSearchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("top_k")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        [NameInMap("way")]
        [Validation(Required=false)]
        public string Way { get; set; }

    }

}
