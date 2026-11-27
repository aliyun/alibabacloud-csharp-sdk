// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLMetricSeries : TeaModel {
        /// <summary>
        /// <para>生效聚合策略，即使未降采样也返回</para>
        /// 
        /// <b>Example:</b>
        /// <para>Last</para>
        /// </summary>
        [NameInMap("Aggregation")]
        [Validation(Required=false)]
        public string Aggregation { get; set; }

        /// <summary>
        /// <para>是否为满足点数上限进行了等宽步数分桶</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Downsampled")]
        [Validation(Required=false)]
        public bool? Downsampled { get; set; }

        /// <summary>
        /// <para>本次查询的精确指标键</para>
        /// 
        /// <b>Example:</b>
        /// <para>actor/ppo_kl</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>按步数升序排列的有限数据点或聚合桶，同一步数取最新源事件。没有有限点时返回 []，不返回 null</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Step&quot;:1,&quot;GmtTime&quot;:&quot;2026-09-10T06:00:00Z&quot;,&quot;Value&quot;:0.012}]</para>
        /// </summary>
        [NameInMap("Points")]
        [Validation(Required=false)]
        public List<RLMetricPoint> Points { get; set; }

    }

}
