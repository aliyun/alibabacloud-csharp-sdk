// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UndeployHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>The environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cqsmtellhtgvo***</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtg***</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The operation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>op-d4favr6m1hk***</para>
        /// </summary>
        [NameInMap("operationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The route ID. This parameter is required when you offline a route of an HTTP API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr-cr82undlhtgrle***</para>
        /// </summary>
        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

    }

}
