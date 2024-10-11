// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DescribeExperimentEnvResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>829F38F6-E2D6-4109-90A6-888160BD16C2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeExperimentEnvResponseBodyResult Result { get; set; }
        public class DescribeExperimentEnvResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("bucketCount")]
            [Validation(Required=false)]
            public int? BucketCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UID</para>
            /// </summary>
            [NameInMap("divideType")]
            [Validation(Required=false)]
            public string DivideType { get; set; }

        }

    }

}
