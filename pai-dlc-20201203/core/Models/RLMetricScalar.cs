// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLMetricScalar : TeaModel {
        /// <summary>
        /// <para>该标量的源事件时间，UTC RFC3339，秒精度</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-10T06:00:00Z</para>
        /// </summary>
        [NameInMap("GmtTime")]
        [Validation(Required=false)]
        public string GmtTime { get; set; }

        /// <summary>
        /// <para>精确且区分大小写的原生指标键</para>
        /// 
        /// <b>Example:</b>
        /// <para>actor/ppo_kl</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>该指标在生效日志窗口内最高已观测步数，0 有效；稀疏指标的步数可以不同</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public long? Step { get; set; }

        /// <summary>
        /// <para>最新已观测值；空值或非有限值为 null，不回退到较早有限值，也不填 0。完整读取时为 Available，空值本身不产生原因码；查询受限或记录损坏时仍为 Partial</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.012</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
