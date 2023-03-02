// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstanceAmountResponseBody : TeaModel {
        /// <summary>
        /// The trend of the number of auto triggered node instances within the specified period of time.
        /// </summary>
        [NameInMap("InstanceCounts")]
        [Validation(Required=false)]
        public List<ListInstanceAmountResponseBodyInstanceCounts> InstanceCounts { get; set; }
        public class ListInstanceAmountResponseBodyInstanceCounts : TeaModel {
            /// <summary>
            /// The number of auto triggered node instances.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The data timestamp at which the number of auto triggered node instances was obtained. This value is a UNIX timestamp.
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
