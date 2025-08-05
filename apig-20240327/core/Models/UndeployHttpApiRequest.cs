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

        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("operationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The route ID. You must specify this parameter when you unpublish the route of an HTTP API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr-cr82undlhtgrle***</para>
        /// </summary>
        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

    }

}
