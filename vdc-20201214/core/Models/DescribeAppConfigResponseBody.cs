// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeAppConfigResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 阈值配置对象
        /// </summary>
        [NameInMap("ThresholdConfig")]
        [Validation(Required=false)]
        public DescribeAppConfigResponseBodyThresholdConfig ThresholdConfig { get; set; }
        public class DescribeAppConfigResponseBodyThresholdConfig : TeaModel {
            [NameInMap("JoinSlowTime")]
            [Validation(Required=false)]
            public long? JoinSlowTime { get; set; }
        };

    }

}
