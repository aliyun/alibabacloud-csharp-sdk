// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateServiceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The IP address of the target instance. This parameter is optional. If not specified, some tasks can match instances by scope (such as instanceIds). This parameter is typically required for heap dump scenarios.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.1</para>
        /// </summary>
        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The task configuration. The value is a JSON string with a maximum length of 65536 characters. This parameter is required for LiveDebug task types. Use a flat JSON structure and pass a single command or probe object directly. Do not wrap it in a commands or probes array. Probe example (dynamic log): {&quot;probeType&quot;:&quot;LOG&quot;,&quot;language&quot;:&quot;java&quot;,&quot;target&quot;:{&quot;typeName&quot;:&quot;com.example.UserService&quot;,&quot;methodName&quot;:&quot;getUser&quot;,&quot;location&quot;:&quot;exit&quot;,&quot;instanceIds&quot;:[&quot;<em>&quot;]},&quot;action&quot;:{&quot;type&quot;:&quot;LOG&quot;,&quot;template&quot;:&quot;userId=${args[0]}&quot;,&quot;templateSegments&quot;:[{&quot;type&quot;:&quot;TEXT&quot;,&quot;value&quot;:&quot;userId=&quot;},{&quot;type&quot;:&quot;EXPRESSION&quot;,&quot;value&quot;:&quot;args[0]&quot;]},&quot;ttl&quot;:&quot;1h&quot;,&quot;captureCount&quot;:100}. Command example (OGNL): {&quot;commandType&quot;:&quot;EVALUATE_EXPRESSION&quot;,&quot;language&quot;:&quot;java&quot;,&quot;params&quot;:{&quot;expression&quot;:&quot;@java.lang.System@getProperty(\&quot;java.home\&quot;)&quot;},&quot;instanceIds&quot;:[&quot;</em>&quot;]}. Note: The Command type must include instanceIds at the top level. For Probe types, instanceIds is placed inside the target object. The action.metricType for METRIC probes can be set to COUNTER, GAUGE, HISTOGRAM, or SUMMARY. The Java Agent supports only COUNTER and GAUGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;probeType&quot;:&quot;LOG&quot;,&quot;language&quot;:&quot;java&quot;,&quot;target&quot;:{&quot;typeName&quot;:&quot;com.example.service.UserServiceImpl&quot;,&quot;methodName&quot;:&quot;findById&quot;,&quot;location&quot;:&quot;exit&quot;,&quot;instanceIds&quot;:[&quot;*&quot;]},&quot;action&quot;:{&quot;type&quot;:&quot;LOG&quot;,&quot;template&quot;:&quot;userId=${args[0]} cost=${durationMs}ms&quot;,&quot;templateSegments&quot;:[{&quot;type&quot;:&quot;TEXT&quot;,&quot;value&quot;:&quot;userId=&quot;},{&quot;type&quot;:&quot;EXPRESSION&quot;,&quot;value&quot;:&quot;args[0]&quot;},{&quot;type&quot;:&quot;TEXT&quot;,&quot;value&quot;:&quot; cost=&quot;},{&quot;type&quot;:&quot;EXPRESSION&quot;,&quot;value&quot;:&quot;durationMs&quot;},{&quot;type&quot;:&quot;TEXT&quot;,&quot;value&quot;:&quot;ms&quot;}]},&quot;ttl&quot;:&quot;1h&quot;,&quot;captureCount&quot;:100}</para>
        /// </summary>
        [NameInMap("taskConfig")]
        [Validation(Required=false)]
        public string TaskConfig { get; set; }

        /// <summary>
        /// <para>The task type. This parameter is required. Valid values: heapdump (heap dump). LiveDebug Probe: live_debug_log_probe, live_debug_snapshot_probe, live_debug_metric_probe, live_debug_span_probe, live_debug_span_tag_probe. LiveDebug Command: live_debug_inspect_object, live_debug_search_type, live_debug_search_method, live_debug_decompile, live_debug_get_thread_info, live_debug_get_runtime_info, live_debug_get_memory_info, live_debug_evaluate_expression, live_debug_modify_logger_level. LiveDebug Code Replace: live_debug_code_replace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live_debug_log_probe</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
