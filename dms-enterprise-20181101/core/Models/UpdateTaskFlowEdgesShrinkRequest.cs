// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowEdgesShrinkRequest : TeaModel {
        /// <summary>
        /// $.parameters[3].schema.example
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// $.parameters[3].schema.enumValueTitles
        /// </summary>
        [NameInMap("Edges")]
        [Validation(Required=false)]
        public string EdgesShrink { get; set; }

        /// <summary>
        /// $.parameters[3].schema.description
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
