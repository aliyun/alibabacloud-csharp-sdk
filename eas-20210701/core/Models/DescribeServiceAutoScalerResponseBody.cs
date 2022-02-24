// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceAutoScalerResponseBody : TeaModel {
        /// <summary>
        /// 服务最大实例数
        /// </summary>
        [NameInMap("MaxReplica")]
        [Validation(Required=false)]
        public int? MaxReplica { get; set; }

        /// <summary>
        /// 服务最小实例数
        /// </summary>
        [NameInMap("MinReplica")]
        [Validation(Required=false)]
        public int? MinReplica { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务名字
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 扩缩控制器控制策略
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public Dictionary<string, object> Strategies { get; set; }

    }

}
