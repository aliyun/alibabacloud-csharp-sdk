// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetMonitorDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;start&quot;:1689245180581,&quot;end&quot;:1689246950582,&quot;queries&quot;:[{&quot;metric&quot;:&quot;aliyunes.elasticsearch.index.docs.count&quot;,&quot;aggregator&quot;:&quot;sum&quot;,&quot;downsample&quot;:&quot;avg&quot;,&quot;tags&quot;:{&quot;resource&quot;:&quot;{appName}&quot;},&quot;filters&quot;:[],&quot;granularity&quot;:&quot;auto&quot;}]}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
