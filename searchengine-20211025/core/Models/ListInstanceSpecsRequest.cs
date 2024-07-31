// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListInstanceSpecsRequest : TeaModel {
        /// <summary>
        /// The node type. Valid values:
        /// 
        /// *   qrs: Query Result Searcher (QRS) Worker
        /// *   search: Searcher Worker
        /// *   index: index node
        /// *   cluster: cluster
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
