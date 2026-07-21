// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DataFilter : TeaModel {
        /// <summary>
        /// <para>The maximum number of evaluation records. This takes effect for both backfill and continuous runs. If not specified, the backend does not write a default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxRecords")]
        [Validation(Required=false)]
        public int? MaxRecords { get; set; }

        /// <summary>
        /// <para>The one-time temporary evaluation input content, primarily used for oneshot tasks. The value is stored as a string. Object or array values are serialized to a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;input&quot;:&quot;用户查询订单状态&quot;,&quot;output&quot;:&quot;已查询到订单状态&quot;}</para>
        /// </summary>
        [NameInMap("provided")]
        [Validation(Required=false)]
        public Dictionary<string, object> Provided { get; set; }

        /// <summary>
        /// <para>The data query filter condition. This takes effect together with the evaluator-level filters.query. In Trace scenarios, you can specify filter expressions such as service name, environment, or labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serviceName=\&quot;checkout-service\&quot;</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The sampling rate percentage. Valid values: 0 to 100. A value of 0 or not specified indicates no sampling. A value of 100 indicates full data. If the value is less than 100, random sampling is applied first, and then the maxRecords limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("samplingRate")]
        [Validation(Required=false)]
        public int? SamplingRate { get; set; }

        [NameInMap("serviceNames")]
        [Validation(Required=false)]
        public List<string> ServiceNames { get; set; }

    }

}
