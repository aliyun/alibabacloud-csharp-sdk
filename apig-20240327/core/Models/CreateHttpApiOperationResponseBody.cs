// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiOperationResponseBody : TeaModel {
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
        /// <para>Operation information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateHttpApiOperationResponseBodyData Data { get; set; }
        public class CreateHttpApiOperationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Operation information.</para>
            /// </summary>
            [NameInMap("operations")]
            [Validation(Required=false)]
            public List<CreateHttpApiOperationResponseBodyDataOperations> Operations { get; set; }
            public class CreateHttpApiOperationResponseBodyDataOperations : TeaModel {
                /// <summary>
                /// <para>Operation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>op-xxx</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

            }

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
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
