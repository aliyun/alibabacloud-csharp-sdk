// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class EnableServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of services that failed to be enabled.</para>
        /// </summary>
        [NameInMap("FailedServices")]
        [Validation(Required=false)]
        public List<EnableServicesResponseBodyFailedServices> FailedServices { get; set; }
        public class EnableServicesResponseBodyFailedServices : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACVS</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1BD3327-6BEE-53AD-8788-D892EB575962</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
