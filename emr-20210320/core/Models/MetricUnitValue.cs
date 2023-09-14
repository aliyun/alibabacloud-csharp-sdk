// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class MetricUnitValue : TeaModel {
        /// <summary>
        /// 指标名称。
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标单位。
        /// </summary>
        [NameInMap("MetricUnit")]
        [Validation(Required=false)]
        public string MetricUnit { get; set; }

    }

}
