// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingAnalyzeResult : TeaModel {
        /// <summary>
        /// 实际资源利用率。
        /// </summary>
        [NameInMap("ActualUsage")]
        [Validation(Required=false)]
        public float? ActualUsage { get; set; }

        /// <summary>
        /// 理想资源用量。
        /// </summary>
        [NameInMap("IdealUsage")]
        [Validation(Required=false)]
        public float? IdealUsage { get; set; }

        /// <summary>
        /// 固定资源释放核数（非master）core。
        /// </summary>
        [NameInMap("ReleaseCores")]
        [Validation(Required=false)]
        public int? ReleaseCores { get; set; }

        /// <summary>
        /// 固定资源保留核数（非master）core。
        /// </summary>
        [NameInMap("ReservedCores")]
        [Validation(Required=false)]
        public int? ReservedCores { get; set; }

    }

}
