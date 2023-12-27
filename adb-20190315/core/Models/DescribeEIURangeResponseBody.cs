// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeEIURangeResponseBody : TeaModel {
        /// <summary>
        /// The queried information about the number of EIUs.
        /// </summary>
        [NameInMap("EIUInfo")]
        [Validation(Required=false)]
        public DescribeEIURangeResponseBodyEIUInfo EIUInfo { get; set; }
        public class DescribeEIURangeResponseBodyEIUInfo : TeaModel {
            /// <summary>
            /// The suggested value for the number of EIUs.
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// The queried range for the number of EIUs.
            /// </summary>
            [NameInMap("EIURange")]
            [Validation(Required=false)]
            public List<long?> EIURange { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("StorageResourceRange")]
            [Validation(Required=false)]
            public List<string> StorageResourceRange { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
