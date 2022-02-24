// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceAutoScalerRequest : TeaModel {
        /// <summary>
        /// 最大 replica 数，需要大于MinReplica
        /// </summary>
        [NameInMap("Max")]
        [Validation(Required=false)]
        public int? Max { get; set; }

        /// <summary>
        /// 最小 replica 数，需要大于0
        /// </summary>
        [NameInMap("Min")]
        [Validation(Required=false)]
        public int? Min { get; set; }

        /// <summary>
        /// map 类型的策略定义
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public CreateServiceAutoScalerRequestStrategies Strategies { get; set; }
        public class CreateServiceAutoScalerRequestStrategies : TeaModel {
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public float? Qps { get; set; }
        };

    }

}
