// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>Response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateHttpApiRouteResponseBodyData Data { get; set; }
        public class CreateHttpApiRouteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Route ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>hr-cr82undlhtgrlej***</para>
            /// </summary>
            [NameInMap("routeId")]
            [Validation(Required=false)]
            public string RouteId { get; set; }

        }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ACFC7A7-45A9-58CF-B2D5-765B60254695</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
