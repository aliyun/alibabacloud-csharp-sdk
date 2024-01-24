// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceSwitchAzoneResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the operation.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeInstanceSwitchAzoneResponseBodyResult Result { get; set; }
        public class DescribeInstanceSwitchAzoneResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the source azoneId.
            /// </summary>
            [NameInMap("OriginAzoneId")]
            [Validation(Required=false)]
            public string OriginAzoneId { get; set; }

            /// <summary>
            /// regionId.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// Indicates whether the job can be switched.
            /// </summary>
            [NameInMap("SwitchAble")]
            [Validation(Required=false)]
            public bool? SwitchAble { get; set; }

            /// <summary>
            /// Target azones.
            /// </summary>
            [NameInMap("TargetAzones")]
            [Validation(Required=false)]
            public DescribeInstanceSwitchAzoneResponseBodyResultTargetAzones TargetAzones { get; set; }
            public class DescribeInstanceSwitchAzoneResponseBodyResultTargetAzones : TeaModel {
                [NameInMap("TargetAzone")]
                [Validation(Required=false)]
                public List<string> TargetAzone { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
