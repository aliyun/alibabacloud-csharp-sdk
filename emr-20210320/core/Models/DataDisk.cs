// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DataDisk : TeaModel {
        /// <summary>
        /// 磁盘类型。
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// 每个节点磁盘数量。
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// 创建ESSD云盘作为数据盘使用时，设置云盘的性能等级。取值范围：
        /// - PL0：单盘最高随机读写IOPS 1万。
        /// - PL1（默认）：单盘最高随机读写IOPS 5万。
        /// - PL2：单盘最高随机读写IOPS 10万。
        /// - PL3：单盘最高随机读写IOPS 100万。
        /// 
        /// 默认值：PL1。
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// 单位GB。
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
