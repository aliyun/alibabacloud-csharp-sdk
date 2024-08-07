// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentVertexNodesShrinkRequest : TeaModel {
        /// <summary>
        /// The types of the edges that you want to query.
        /// </summary>
        [NameInMap("EdgeLabelList")]
        [Validation(Required=false)]
        public string EdgeLabelListShrink { get; set; }

        /// <summary>
        /// The page number. Valid values start from 1.
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values start from 1.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The ID of the node that you want to query.
        /// 
        /// >  You can call the [QueryIncidentTracingDetail](~~QueryIncidentTracingDetail~~) operation to query the node ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VertexId")]
        [Validation(Required=false)]
        public string VertexId { get; set; }

        /// <summary>
        /// The node label. Valid values include but are not limited to:
        /// 
        /// *   **process**
        /// *   **file**
        /// *   **alert**
        /// *   **ip**
        /// *   **domain**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VertexLabel")]
        [Validation(Required=false)]
        public string VertexLabel { get; set; }

    }

}
