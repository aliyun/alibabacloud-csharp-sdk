// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLMetricPoint : TeaModel {
        /// <summary>
        /// <para>UTC RFC3339，秒精度；聚合桶使用最后一个有效源点的时间，不表示极值发生时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-10T06:00:00Z</para>
        /// </summary>
        [NameInMap("GmtTime")]
        [Validation(Required=false)]
        public string GmtTime { get; set; }

        /// <summary>
        /// <para>去重且排除非有限值后的有效源点数，正整数；仅聚合桶返回</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SampleCount")]
        [Validation(Required=false)]
        public long? SampleCount { get; set; }

        /// <summary>
        /// <para>桶内有效点的最小步数，包含；仅聚合桶返回</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StartStep")]
        [Validation(Required=false)]
        public long? StartStep { get; set; }

        /// <summary>
        /// <para>非负框架步数，0 有效；聚合桶使用最后一个有效源点的步数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public long? Step { get; set; }

        /// <summary>
        /// <para>原始有限数值或桶聚合结果。非有限点省略；缺失区间不补点或填 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.012</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
