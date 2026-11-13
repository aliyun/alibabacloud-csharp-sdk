// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class GetMetricDataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>时序查询的结束时间，区间不含此时刻。使用 UTC 整秒时间，须晚于 startTime。一次最多查询 7 天。区间须包含至少一个按 period 对齐的时间点，且这些时间点不能晚于当前时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:02:00Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>例如，按 teamID 分组可分别查看各团队的指标。可组合最多 4 个不同的分组键，可用键因指标而异。不填时返回查询范围的整体结果。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;teamID&quot;]</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public string GroupByShrink { get; set; }

        /// <summary>
        /// <para>要查询的指标名称。一次可查询 1～16 个不同的指标。可选指标和查询范围见指标目录。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cpuUsedCores&quot;]</para>
        /// </summary>
        [NameInMap("metricNames")]
        [Validation(Required=false)]
        public string MetricNamesShrink { get; set; }

        /// <summary>
        /// <para>时序查询的时间间隔，单位为秒。可选 60、300、900、1800、3600、86400。60 对应整分钟，86400 对应每日 UTC 零点。部分统计指标的计算时长随间隔变化。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>要查询的沙箱 ID。请同时填写所属的 teamID 和 templateID，并选择支持按沙箱查询的指标。</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbx-62105527-699e-48df-ad3b-7425001ae4f2</para>
        /// </summary>
        [NameInMap("sandboxID")]
        [Validation(Required=false)]
        public string SandboxID { get; set; }

        /// <summary>
        /// <para>按沙箱版本查询沙箱数量。仅适用于 sandboxCount，可选 eco、std、pro、ent。</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("sandboxPlan")]
        [Validation(Required=false)]
        public string SandboxPlan { get; set; }

        /// <summary>
        /// <para>时序查询的开始时间，包含此时刻。请按示例填写 UTC 时间，精确到秒，并同时填写 endTime。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>要查询的团队 ID。不填时查询当前账号。</para>
        /// 
        /// <b>Example:</b>
        /// <para>70d1c834-0333-58d8-97ac-5336eb9179eb</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>要查询的模板 ID。请同时填写模板所属的 teamID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>4hrtmghh2nzrsdh6yr65</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        /// <summary>
        /// <para>查询某一时刻时，只填写 time。请按示例填写当前或过去的 UTC 时间，精确到秒。省略所有时间参数时，查询当前时刻。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:01:00Z</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
