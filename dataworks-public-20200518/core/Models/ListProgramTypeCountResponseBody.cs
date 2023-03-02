// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProgramTypeCountResponseBody : TeaModel {
        /// <summary>
        /// The type and number of nodes.
        /// </summary>
        [NameInMap("ProgramTypeAndCounts")]
        [Validation(Required=false)]
        public List<ListProgramTypeCountResponseBodyProgramTypeAndCounts> ProgramTypeAndCounts { get; set; }
        public class ListProgramTypeCountResponseBodyProgramTypeAndCounts : TeaModel {
            /// <summary>
            /// The number of nodes.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The type of the node.
            /// </summary>
            [NameInMap("ProgramType")]
            [Validation(Required=false)]
            public string ProgramType { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate logs and troubleshoot problems.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
