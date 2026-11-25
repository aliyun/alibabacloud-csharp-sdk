// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchDeployHttpApiRoutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code of the API call. For the acceptance or publish result of each route, see data.results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The route-level results of the batch publish. A synchronous publish also returns the number of successful and failed routes. An asynchronous publish returns only the route-level acceptance results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchDeployHttpApiRoutesResponseBodyData Data { get; set; }
        public class BatchDeployHttpApiRoutesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of routes that fail to be published in the batch. This parameter is returned only for a synchronous publish and can be 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            /// <summary>
            /// <para>A map of results with route IDs as keys. If other routes in the same batch fail, the successfully published routes remain valid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;hr-example001&quot;:{&quot;routeId&quot;:&quot;hr-example001&quot;,&quot;status&quot;:&quot;Succeeded&quot;},&quot;hr-example002&quot;:{&quot;routeId&quot;:&quot;hr-example002&quot;,&quot;status&quot;:&quot;Succeeded&quot;}}</para>
            /// </summary>
            [NameInMap("results")]
            [Validation(Required=false)]
            public Dictionary<string, DataResultsValue> Results { get; set; }

            /// <summary>
            /// <para>The number of routes that are successfully published in the batch. This parameter is returned only for a synchronous publish and can be 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

        }

        /// <summary>
        /// <para>The response message of the API call. If a route fails or is rejected, see the errorMessage of the corresponding route for the cause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID of the API call. You can invoke this ID to locate the active request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7B8A1C2-1234-5678-90AB-CDEF12345678</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
