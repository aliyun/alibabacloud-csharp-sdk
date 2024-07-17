// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListTablesRequest : TeaModel {
        /// <summary>
        /// Specifies whether the OpenSearch Vector Search Edition instance is of the new version.
        /// </summary>
        [NameInMap("newMode")]
        [Validation(Required=false)]
        public bool? NewMode { get; set; }

    }

}
