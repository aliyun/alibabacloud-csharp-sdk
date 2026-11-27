// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLFlowAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>查询窗口截止时间，采用 RFC3339 格式。未提供时使用服务端当前 UTC 时间，并向下对齐到 30 秒边界。为容纳日志采集延迟，实际读取的采集时间上界在该值基础上延后 5 分钟，并非严格按事件发生时间过滤。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-07T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>查询窗口起始时间，采用 RFC3339 格式。未提供时默认为 EndTime 前 7 天；必须早于 EndTime，时间跨度不得超过 30 天。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-04T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
