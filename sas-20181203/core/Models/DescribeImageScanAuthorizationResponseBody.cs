// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageScanAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// The authorization status of image scans.
        /// </summary>
        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public DescribeImageScanAuthorizationResponseBodyAuthStatus AuthStatus { get; set; }
        public class DescribeImageScanAuthorizationResponseBodyAuthStatus : TeaModel {
            /// <summary>
            /// Indicates whether Security Center is authorized to scan images. Valid values:
            /// * **true**: yes 
            /// * **false**: no
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
