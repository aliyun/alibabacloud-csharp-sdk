// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerServiceK8sClusterKritisStatusResponseBody : TeaModel {
        /// <summary>
        /// The Kritis status of the ACK cluster.
        /// </summary>
        [NameInMap("KritisStatus")]
        [Validation(Required=false)]
        public DescribeContainerServiceK8sClusterKritisStatusResponseBodyKritisStatus KritisStatus { get; set; }
        public class DescribeContainerServiceK8sClusterKritisStatusResponseBodyKritisStatus : TeaModel {
            /// <summary>
            /// Indicates whether Kritis is installed. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Install")]
            [Validation(Required=false)]
            public bool? Install { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
