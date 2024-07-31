// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceCountTrendResponseBody : TeaModel {
        /// <summary>
        /// The quantity trend of instances.
        /// </summary>
        [NameInMap("InstanceCounts")]
        [Validation(Required=false)]
        public List<GetInstanceCountTrendResponseBodyInstanceCounts> InstanceCounts { get; set; }
        public class GetInstanceCountTrendResponseBodyInstanceCounts : TeaModel {
            /// <summary>
            /// The number of instances.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The data timestamp.
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
