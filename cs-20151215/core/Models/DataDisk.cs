// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DataDisk : TeaModel {
        /// <summary>
        /// 开启云盘备份时的自动备份策略。
        /// </summary>
        [NameInMap("auto_snapshot_policy_id")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// 数据盘类型
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// 是否对数据盘加密。
        /// </summary>
        [NameInMap("encrypted")]
        [Validation(Required=false)]
        public string Encrypted { get; set; }

        /// <summary>
        /// 数据盘磁盘性能，只针对ESSD磁盘生效
        /// </summary>
        [NameInMap("performance_level")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// 数据盘大小，取值范围：40～32767
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
