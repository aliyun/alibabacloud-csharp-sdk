// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DataFilter : TeaModel {
        /// <summary>
        /// <para>The maximum number of evaluation records. This parameter takes effect for both backfill and continuous runs. If this parameter is not specified, the backend does not apply an additional default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxRecords")]
        [Validation(Required=false)]
        public int? MaxRecords { get; set; }

        /// <summary>
        /// <para>The single-shot input content for temporary evaluation, which is primarily used for one-shot tasks. Values are saved as strings. Object or array values are serialized into JSON strings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;input&quot;:&quot;User queries order status&quot;,&quot;output&quot;:&quot;Order status queried&quot;}</para>
        /// </summary>
        [NameInMap("provided")]
        [Validation(Required=false)]
        public Dictionary<string, object> Provided { get; set; }

        /// <summary>
        /// <para>The data query filter conditions that take effect together with the evaluator-level filters.query. For trace scenarios, you can specify filter expressions such as service name, environment, and tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serviceName=\&quot;checkout-service\&quot;</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The sampling rate percentage. Valid values: 0 to 100. A value of 0 or an unspecified value indicates no sampling. A value of 100 indicates full sampling. If the value is less than 100, random sampling is performed first, and then the maxRecords limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("samplingRate")]
        [Validation(Required=false)]
        public int? SamplingRate { get; set; }

        /// <summary>
        /// <para>The list of service names used to restrict the services involved in data filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;checkout-service&quot;]</para>
        /// </summary>
        [NameInMap("serviceNames")]
        [Validation(Required=false)]
        public List<string> ServiceNames { get; set; }

    }

}
