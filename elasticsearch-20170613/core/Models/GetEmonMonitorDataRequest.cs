// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetEmonMonitorDataRequest : TeaModel {
        /// <summary>
        /// <para>The Grafana metric monitoring query conditions, including the query start time, metric expression, and metric query list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;start&quot;:1522127381471,&quot;queries&quot;:[{&quot;metric&quot;:&quot;elasticbuild.elasticsearch.source.total_doc_count&quot;,&quot;aggregator&quot;:&quot;sum&quot;,&quot;downsample&quot;:&quot;avg&quot;,&quot;tags&quot;:{&quot;taskName&quot;:&quot;et-testtsk&quot;,&quot;userId&quot;:&quot;123456&quot;},&quot;granularity&quot;:&quot;1m&quot;}],&quot;limit&quot;:&quot;&quot;,&quot;end&quot;:1522129151000}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
