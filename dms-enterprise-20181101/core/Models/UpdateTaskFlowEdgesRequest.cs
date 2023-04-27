// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowEdgesRequest : TeaModel {
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
        public List<UpdateTaskFlowEdgesRequestEdges> Edges { get; set; }
        public class UpdateTaskFlowEdgesRequestEdges : TeaModel {
            /// <summary>
            /// $.parameters[2].schema.description
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// $.parameters[2].schema.example
            /// </summary>
            [NameInMap("NodeEnd")]
            [Validation(Required=false)]
            public long? NodeEnd { get; set; }

            /// <summary>
            /// $.parameters[2].schema.enumValueTitles
            /// </summary>
            [NameInMap("NodeFrom")]
            [Validation(Required=false)]
            public long? NodeFrom { get; set; }

        }

        /// <summary>
        /// $.parameters[3].schema.description
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
