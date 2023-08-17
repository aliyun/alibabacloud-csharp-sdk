// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeComputeResourceResponseBody : TeaModel {
        /// <summary>
        /// Details of computing resource specifications.
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public List<DescribeComputeResourceResponseBodyComputeResource> ComputeResource { get; set; }
        public class DescribeComputeResourceResponseBodyComputeResource : TeaModel {
            /// <summary>
            /// The specifications of computing resources displayed in the console.
            /// </summary>
            [NameInMap("DisplayValue")]
            [Validation(Required=false)]
            public string DisplayValue { get; set; }

            /// <summary>
            /// The actual specifications of computing resources.
            /// </summary>
            [NameInMap("RealValue")]
            [Validation(Required=false)]
            public string RealValue { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
