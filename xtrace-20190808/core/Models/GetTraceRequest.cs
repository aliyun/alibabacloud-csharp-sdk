// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class GetTraceRequest : TeaModel {
        /// <summary>
        /// <para>The type of the application. You can leave this parameter empty or set this parameter to <c>XTRACE</c>. We recommend that you leave this parameter empty.</para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, traces reported to Managed Service for OpenTelemetry and Application Real-Time Monitoring Service (ARMS) can be queried.</description></item>
        /// <item><description>If you set this parameter to <c>XTRACE</c>, only traces reported to Managed Service for OpenTelemetry can be queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>XTRACE</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The trace ID, which is the unique identifier of the trace.</para>
        /// <para>You can obtain the trace ID on the <b>Trace Explorer</b> page in the Managed Service for OpenTelemetry console or by calling the <a href="https://help.aliyun.com/document_detail/2399674.html~">SearchTraces</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1c6881aab84191a4</para>
        /// </summary>
        [NameInMap("TraceID")]
        [Validation(Required=false)]
        public string TraceID { get; set; }

    }

}
