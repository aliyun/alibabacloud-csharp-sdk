// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeNsasSuspEventTypeResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information about the alert type.
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<DescribeNsasSuspEventTypeResponseBodyEventTypes> EventTypes { get; set; }
        public class DescribeNsasSuspEventTypeResponseBodyEventTypes : TeaModel {
            /// <summary>
            /// The name of the alert type.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of assets for which an alert of the type is generated.
            /// </summary>
            [NameInMap("SuspEventCount")]
            [Validation(Required=false)]
            public int? SuspEventCount { get; set; }

            /// <summary>
            /// The alert type.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
