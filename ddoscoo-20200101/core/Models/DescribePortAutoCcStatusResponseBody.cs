// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortAutoCcStatusResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the configurations of the Intelligent Protection policy.
        /// </summary>
        [NameInMap("PortAutoCcStatus")]
        [Validation(Required=false)]
        public List<DescribePortAutoCcStatusResponseBodyPortAutoCcStatus> PortAutoCcStatus { get; set; }
        public class DescribePortAutoCcStatusResponseBodyPortAutoCcStatus : TeaModel {
            /// <summary>
            /// The mode of the Intelligent Protection policy. Valid values:
            /// 
            /// *   **normal**
            /// *   **loose**
            /// *   **strict**
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The status of the Intelligent Protection policy. Valid values:
            /// 
            /// *   **on**: enabled
            /// *   **off**: disabled
            /// </summary>
            [NameInMap("Switch")]
            [Validation(Required=false)]
            public string Switch { get; set; }

            /// <summary>
            /// The protection mode for ports 80 and 443. Valid values:
            /// 
            /// *   **normal**
            /// *   **loose**
            /// *   **strict**
            /// </summary>
            [NameInMap("WebMode")]
            [Validation(Required=false)]
            public string WebMode { get; set; }

            /// <summary>
            /// The status of the Intelligent Protection policy for ports 80 and 443. Valid values:
            /// 
            /// *   **on**: enabled
            /// *   **off**: disabled
            /// </summary>
            [NameInMap("WebSwitch")]
            [Validation(Required=false)]
            public string WebSwitch { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
