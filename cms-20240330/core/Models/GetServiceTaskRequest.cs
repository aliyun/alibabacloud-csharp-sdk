// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetServiceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The task type. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>heapdump: heap dump.</description></item>
        /// <item><description>LiveDebug Probe: live_debug_log_probe, live_debug_snapshot_probe, live_debug_metric_probe, live_debug_span_probe, live_debug_span_tag_probe.</description></item>
        /// <item><description>LiveDebug Command: live_debug_inspect_object, live_debug_search_type, live_debug_search_method, live_debug_decompile, live_debug_get_thread_info, live_debug_get_runtime_info, live_debug_get_memory_info, live_debug_evaluate_expression, live_debug_modify_logger_level.</description></item>
        /// <item><description>LiveDebug code hot replacement: live_debug_code_replace.</description></item>
        /// </list>
        /// <para>The value must be the same as the type specified during task creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live_debug_log_probe</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
