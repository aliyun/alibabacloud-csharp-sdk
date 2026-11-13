// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayDfpExtProcServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result code. The value is Ok if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The binding information of the gateway dynamic forwarding ExtProc service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bound&quot;:true,&quot;serviceId&quot;:&quot;svc-cr8k0udlhtgt80sh7png&quot;,&quot;servicePort&quot;:9002}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayDfpExtProcServiceResponseBodyData Data { get; set; }
        public class GetGatewayDfpExtProcServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the gateway is bound to a dynamic forwarding ExtProc service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("bound")]
            [Validation(Required=false)]
            public bool? Bound { get; set; }

            /// <summary>
            /// <para>The ID of the bound ExtProc gRPC service. This parameter is not returned if no service is bound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-cr8k0udlhtgt80sh7png</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The gRPC port of the bound service. This parameter is not returned if no service is bound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9002</para>
            /// </summary>
            [NameInMap("servicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

        }

        /// <summary>
        /// <para>The request result description, which contains the fault message if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7B8A1C2-1234-5678-90AB-CDEF12345678</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
