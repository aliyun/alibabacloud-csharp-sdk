// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListServiceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return per page. Valid values: 0 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Pass the nextToken value from the previous response as is. You can leave this parameter empty for the first query. The server returns an encrypted hexadecimal string (internal format: {md5}#{dbId}) with a maximum length of 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d23d8f3f0f0cd1984566b1986c9343122fa0385a05c09694c17fe87709f3eb56d1a7ead56b4a2536</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search condition. The value is a JSON string with a maximum length of 1,024 characters. For heapdump, you can use this parameter to filter by conditions such as IP address. Example for pprof: {&quot;ip&quot;:&quot;10.0.0.1&quot;,&quot;start&quot;:1711843200000,&quot;end&quot;:1711846800000,&quot;profileType&quot;:1}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ip&quot;:&quot;10.0.0.1&quot;}</para>
        /// </summary>
        [NameInMap("searchCondition")]
        [Validation(Required=false)]
        public string SearchCondition { get; set; }

        /// <summary>
        /// <para>The task type. Valid values: heapdump (heap dump); LiveDebug Probe: live_debug_log_probe, live_debug_snapshot_probe, live_debug_metric_probe, live_debug_span_probe, and live_debug_span_tag_probe; LiveDebug Command: live_debug_inspect_object, live_debug_search_type, live_debug_search_method, live_debug_decompile, live_debug_get_thread_info, live_debug_get_runtime_info, live_debug_get_memory_info, live_debug_evaluate_expression, and live_debug_modify_logger_level; LiveDebug code hot replacement: live_debug_code_replace. The list operation also supports pprof.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live_debug_log_probe</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
