// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetProductRefResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProductRefResponseBodyData Data { get; set; }
        public class GetProductRefResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API configurations currently associated with the API product. The structure is derived from the common struct HiMarketProductRefConfig. This struct contains the gatewayId and apigRefConfig members. The inner apigRefConfig struct contains the mcpServerId, mcpRouteId, mcpServerName, agentApiId, agentApiName, modelApiId, and modelApiName members.</para>
            /// </summary>
            [NameInMap("apigRefConfig")]
            [Validation(Required=false)]
            public HiMarketProductRefConfig ApigRefConfig { get; set; }

            /// <summary>
            /// <para>The gateway ID. The ID of the gateway instance where the association configuration of the API product resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-123456</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
