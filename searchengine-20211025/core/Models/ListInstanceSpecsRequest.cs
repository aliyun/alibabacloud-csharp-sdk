// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListInstanceSpecsRequest : TeaModel {
        /// <summary>
        /// The node type. Valid values: qrs, search, index, and cluster. qrs specifies an Query Result Searcher (QRS) worker, search specifies a searcher worker, index specifies an index node, and cluster specifies a cluster.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
