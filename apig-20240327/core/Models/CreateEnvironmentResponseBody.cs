// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateEnvironmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Schema of Response</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateEnvironmentResponseBodyData Data { get; set; }
        public class CreateEnvironmentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The request ID, which is used to trace the call link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

        }

        /// <summary>
        /// <para>rg-acfmycs5expl7oq</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C3B9A12-3868-5EB9-8BEA-F99E03DD125C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
