// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSaasDataUnitUsageRequest : TeaModel {
        /// <summary>
        /// <para>UTC时间，格式yyyy-MM-ddTHH:mm:ssZ，秒必须为00。必须晚于StartTime且不晚于请求时刻，不自动裁剪查询范围。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-20T02:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>未删除的SaaS服务实例ID，不接受普通DBInstanceId替代。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agdb-example</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>UTC时间，格式yyyy-MM-ddTHH:mm:ssZ，秒必须为00。不得早于请求时刻前30天；与EndTime组成左闭右开区间，跨度最多7天。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>支持hour（UTC小时）或day（UTC日），未传默认hour。仅决定趋势汇总方式，不在响应中回显。</para>
        /// 
        /// <b>Example:</b>
        /// <para>hour</para>
        /// </summary>
        [NameInMap("TimeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

    }

}
