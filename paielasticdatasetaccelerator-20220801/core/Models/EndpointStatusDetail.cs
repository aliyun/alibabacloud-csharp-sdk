// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class EndpointStatusDetail : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{ 	&quot;slot-j6co2fcd&quot;: {   	&quot;Ip&quot;: &quot;10.0.0.2&quot;, 		&quot;Port&quot;: 7001 	}, 	&quot;slot-asdgys4d&quot;: {   	&quot;Ip&quot;: &quot;10.0.0.3&quot;, 		&quot;Port&quot;: 7002 	} }</para>
        /// </summary>
        [NameInMap("IpPortMapping")]
        [Validation(Required=false)]
        public Dictionary<string, IpPort> IpPortMapping { get; set; }

    }

}
