// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ClusterForReq : TeaModel {
        /// <summary>
        /// Cover
        /// </summary>
        [NameInMap("Cover")]
        [Validation(Required=false)]
        public ClusterForReqCover Cover { get; set; }
        public class ClusterForReqCover : TeaModel {
            [NameInMap("Figures")]
            [Validation(Required=false)]
            public List<ClusterForReqCoverFigures> Figures { get; set; }
            public class ClusterForReqCoverFigures : TeaModel {
                public string FigureId { get; set; }
            }
        };

        /// <summary>
        /// CustomId
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// CustomLabels
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// ObjectId
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

    }

}
