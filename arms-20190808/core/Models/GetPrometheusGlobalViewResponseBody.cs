// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetPrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. 200 is success, other status codes are exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The struct returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;clusterId&quot;:&quot;The ID of the global aggregation instance.&quot;, &quot;groupName&quot;:&quot;The name of the global aggregation instance.&quot;, &quot;dataSources&quot;:[ { &quot;sourceName&quot;:&quot;The name of the data source.- ArmsPrometheus No.1&quot;, &quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;, &quot;userId&quot;:&quot;UserID&quot;, &quot;clusterId&quot;:&quot;ClusterId&quot; }, // more datasources ] }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>Returns a hint message for the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>743AD493-D006-53BD-AAEC-DDCE7FB68EA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
