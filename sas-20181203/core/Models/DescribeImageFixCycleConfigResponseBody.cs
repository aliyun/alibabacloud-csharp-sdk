// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageFixCycleConfigResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageFixCycleConfigResponseBodyData Data { get; set; }
        public class DescribeImageFixCycleConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The cycle of the scheduled fix. Unit: day.
            /// </summary>
            [NameInMap("ImageFixCycle")]
            [Validation(Required=false)]
            public int? ImageFixCycle { get; set; }

            /// <summary>
            /// Indicates whether the scheduled fix of image risks is enabled.
            /// 
            /// *   **on**: enabled
            /// *   **off**: disabled
            /// </summary>
            [NameInMap("ImageFixSwitch")]
            [Validation(Required=false)]
            public string ImageFixSwitch { get; set; }

            /// <summary>
            /// The range of the scheduled fix. The value of this parameter is in the JSON format and contains the following fields:
            /// 
            /// *   **type**: The type of the image risk. The value is fixed to repo.
            /// *   **target**: The content of the image risk. The value is in the format of Namespace/Image repository.
            /// </summary>
            [NameInMap("ImageFixTarget")]
            [Validation(Required=false)]
            public string ImageFixTarget { get; set; }

            /// <summary>
            /// The time range during which the image was modified. Unit: day.
            /// </summary>
            [NameInMap("ImageTimeRange")]
            [Validation(Required=false)]
            public int? ImageTimeRange { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
