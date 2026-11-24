// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchDeployHttpApiRoutesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to publish routes asynchronously. Default value: true. If set to true, the acceptance results of the routes are returned. If set to false, the system waits for the batch processing to complete and returns the final results and statistics for each route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>Specifies whether to publish all routes visible to the current user under the API. Default value: false. If you set this parameter to true, all visible routes are published and the routeIds parameter is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("deployAll")]
        [Validation(Required=false)]
        public bool? DeployAll { get; set; }

        /// <summary>
        /// <para>The list of route IDs to publish. If deployAll is omitted or set to false, at least one route ID must be provided. If any route does not exist or belongs to another API, the entire batch request is rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;hr-example001&quot;,&quot;hr-example002&quot;]</para>
        /// </summary>
        [NameInMap("routeIds")]
        [Validation(Required=false)]
        public List<string> RouteIds { get; set; }

    }

}
