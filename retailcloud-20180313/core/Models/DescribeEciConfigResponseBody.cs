// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeEciConfigResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// errMsg
        /// </summary>
        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeEciConfigResponseBodyResult Result { get; set; }
        public class DescribeEciConfigResponseBodyResult : TeaModel {
            [NameInMap("AppEnvId")]
            [Validation(Required=false)]
            public long? AppEnvId { get; set; }
            [NameInMap("EipBandwidth")]
            [Validation(Required=false)]
            public int? EipBandwidth { get; set; }
            [NameInMap("EnableEciSchedulePolicy")]
            [Validation(Required=false)]
            public bool? EnableEciSchedulePolicy { get; set; }
            [NameInMap("MirrorCache")]
            [Validation(Required=false)]
            public bool? MirrorCache { get; set; }
            [NameInMap("NormalInstanceLimit")]
            [Validation(Required=false)]
            public int? NormalInstanceLimit { get; set; }
            [NameInMap("ScheduleVirtualNode")]
            [Validation(Required=false)]
            public bool? ScheduleVirtualNode { get; set; }
        };

    }

}
