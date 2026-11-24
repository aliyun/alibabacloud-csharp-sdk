// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DataResultsValue : TeaModel {
        /// <summary>
        /// <para>The route ID corresponding to the result, which is the same as the key in results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr-example001</para>
        /// </summary>
        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        /// <summary>
        /// <para>For asynchronous publishing, Pending indicates that the request is accepted, and Rejected indicates that the request is rejected before submission. For synchronous publishing, Succeeded indicates that the route is successfully published, and Failed indicates that the publishing failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The cause of the route being rejected or failing to be published. This parameter is returned when the status is Rejected or Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ErrorType: Conflict, ErrorCode: DeployRouteForbidden, Message: the route  example-route is not allowed to deploy when it\&quot;s status is Deploying., Params: [example-route Deploying]</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

    }

}
