// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetRiskNotificationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRiskNotificationResponseBodyData Data { get; set; }
        public class GetRiskNotificationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-xxxx</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isMute")]
            [Validation(Required=false)]
            public bool? IsMute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GW_VERSION_EXPIRED</para>
            /// </summary>
            [NameInMap("riskCode")]
            [Validation(Required=false)]
            public string RiskCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE1BA0DF-D730-501D-B962-B8B1C23B4667</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
