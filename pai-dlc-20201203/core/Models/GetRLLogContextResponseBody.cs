// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLLogContextResponseBody : TeaModel {
        /// <summary>
        /// <para>Lines 数组中用于定位的参考行下标，从 0 开始；可能对应锚点或其邻近日志，不保证与原始锚点消息精确匹配。未提供时表示本次未返回可用的参考下标。</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AnchorIndex")]
        [Validation(Required=false)]
        public int? AnchorIndex { get; set; }

        /// <summary>
        /// <para>作业 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-xxxxxxxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>按定位时间升序排列的上下文日志。采集时间定位最多返回 201 行；日志时间定位返回锚点前后 5 秒范围内的日志，并可能缩小返回范围。结果不保证包含原始锚点日志。</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public List<RLLogContextLine> Lines { get; set; }

        /// <summary>
        /// <para>日志定位方式。agent_collect_time 表示按采集时间定位，raw_time_cluster 表示按日志时间定位；定位方式本身不保证精确命中锚点。</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_collect_time</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>请求 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>日志时间定位是否触及 5000 条的数量限制，为 true 时上下文可能不完整；采集时间定位时为 false，不能据此判断全部日志是否已完整返回。</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Truncated")]
        [Validation(Required=false)]
        public bool? Truncated { get; set; }

    }

}
