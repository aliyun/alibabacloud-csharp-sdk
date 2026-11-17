// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code or POP error code. A value of Success indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateConnectionResponseBodyData Data { get; set; }
        public class CreateConnectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the connection configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connection-demo</para>
            /// </summary>
            [NameInMap("ConnectionName")]
            [Validation(Required=false)]
            public string ConnectionName { get; set; }

        }

        /// <summary>
        /// <para>The additional information. If the request is successful, success is returned. If the request fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7DA60DED-CD36-5837-B848-C01A23D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
