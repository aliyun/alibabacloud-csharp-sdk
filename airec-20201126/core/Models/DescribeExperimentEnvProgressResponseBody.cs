// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DescribeExperimentEnvProgressResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>E3D6FE3B-B7C2-43DA-9A13-5EA837ACED9B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeExperimentEnvProgressResponseBodyResult Result { get; set; }
        public class DescribeExperimentEnvProgressResponseBodyResult : TeaModel {
            [NameInMap("progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
