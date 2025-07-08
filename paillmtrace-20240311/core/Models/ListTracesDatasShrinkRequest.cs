// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ListTracesDatasShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The value of the attributes.service.app.user_id field in the trace record. It can contain upper and lower case letters, digits, dot (.), hyphen (-), and underscore (_). It is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>end-user.12345</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>Other filter parameters</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string FiltersShrink { get; set; }

        /// <summary>
        /// <para>Whether to return only trace records containing spans with a non-empty events. Example: Suppose a trace has 3 spans. If this parameter is True, this trace meets the condition when any one of the 3 spans has a non-empty events. The default value is False. The events is not used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("HasEvents")]
        [Validation(Required=false)]
        public bool? HasEvents { get; set; }

        /// <summary>
        /// <para>Whether to return only trace records containing spans with a non-empty statusMessage. Example: Suppose a trace has 3 spans. If this parameter is True, this trace meets the condition when any one of the 3 spans has a non-empty statusMessage. The default value is False. The statusMessage is not used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("HasStatusMessage")]
        [Validation(Required=false)]
        public bool? HasStatusMessage { get; set; }

        /// <summary>
        /// <para>The value of the resources.service.app.name field in the trace record. It can contain upper and lower case letters, digits, dot (.), hyphen (-), and underscore (_). Must be an exact match. It is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My.super_LLM-app2</para>
        /// </summary>
        [NameInMap("LlmAppName")]
        [Validation(Required=false)]
        public string LlmAppName { get; set; }

        [NameInMap("MaxDuration")]
        [Validation(Required=false)]
        public float? MaxDuration { get; set; }

        /// <summary>
        /// <para>The upper limit of the search time range, in UTC format (YYYY-mm-dd or YYYY-MM-DD HH:mm:ss). By default, the value is (current time +10 minutes)</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-31
        /// 2024-12-31 23:59:59</para>
        /// </summary>
        [NameInMap("MaxTime")]
        [Validation(Required=false)]
        public string MaxTime { get; set; }

        [NameInMap("MinDuration")]
        [Validation(Required=false)]
        public float? MinDuration { get; set; }

        /// <summary>
        /// <para>The lower limit of the search time range, in UTC format (YYYY-mm-dd or YYYY-MM-DD HH:mm:ss). By default, the value is (current time - 2 days).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-31
        /// 2024-12-31 23:59:59</para>
        /// </summary>
        [NameInMap("MinTime")]
        [Validation(Required=false)]
        public string MinTime { get; set; }

        /// <summary>
        /// <para>Whether the returned JSON data can be directly converted to OpenTelemetry TracesData protobuf object. Default value: False. JSON data that is compatible with OpenTelemetry is more complex. Such data is generally not required unless you want to generate a protobuf object of OpenTelemetry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("OpentelemetryCompatible")]
        [Validation(Required=false)]
        public bool? OpentelemetryCompatible { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The value of the resources.service.owner.sub_id field in the trace record. It can contain upper and lower case letters, digits, dot (.), hyphen (-), and underscore (_). It is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("OwnerSubId")]
        [Validation(Required=false)]
        public string OwnerSubId { get; set; }

        /// <summary>
        /// <para>The page number. Page starts from page 1. Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field used to sort the returned results. Valid values: StartTime and Duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StartTime
        /// Duration</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b></description></item>
        /// <item><description><b>DESC</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC
        /// ASC</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The list of span IDs. Each trace record contains one or more spans.</para>
        /// </summary>
        [NameInMap("SpanIds")]
        [Validation(Required=false)]
        public string SpanIdsShrink { get; set; }

        [NameInMap("SpanName")]
        [Validation(Required=false)]
        public string SpanName { get; set; }

        /// <summary>
        /// <para>The list of trace IDs.</para>
        /// </summary>
        [NameInMap("TraceIds")]
        [Validation(Required=false)]
        public string TraceIdsShrink { get; set; }

        /// <summary>
        /// <para>The content simplification method for returned trace data to reduce the data volume.</para>
        /// <para>REMOVE_EMBEDDING: Removes all embedding array contents.</para>
        /// <para>ROOT_ONLY: Returns only the root span for each trace, with the root span content also having the REMOVE_EMBEDDING applied.</para>
        /// <para>Blank: Maintains the original data without simplification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REMOVE_EMBEDDING
        /// ROOT_ONLY</para>
        /// </summary>
        [NameInMap("TraceReduceMethod")]
        [Validation(Required=false)]
        public string TraceReduceMethod { get; set; }

    }

}
