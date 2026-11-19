// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261105.Models
{
    public class OpenServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of a non-2xx error response, which are mutually exclusive with the status, orderId, and spInstanceId of a normal response.</para>
        /// </summary>
        [NameInMap("error")]
        [Validation(Required=false)]
        public OpenServiceResponseBodyError Error { get; set; }
        public class OpenServiceResponseBodyError : TeaModel {
            /// <summary>
            /// <para>The error code recognizable by programs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INVALID_REQUEST</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error description.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>invalid request</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The correlation ID of the current call.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>open-service-001</para>
            /// </summary>
            [NameInMap("request_id")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <para>The order ID associated with the service activation process. Returned when an order exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-example-001</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The service instance ID returned after successful activation and settlement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-example-001</para>
        /// </summary>
        [NameInMap("spInstanceId")]
        [Validation(Required=false)]
        public string SpInstanceId { get; set; }

        /// <summary>
        /// <para>The test or activation result. TEST_OK indicates that the call validation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST_OK</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
