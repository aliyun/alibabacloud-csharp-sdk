// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class EnableServicesResponseBody : TeaModel {
        [NameInMap("FailedServices")]
        [Validation(Required=false)]
        public List<EnableServicesResponseBodyFailedServices> FailedServices { get; set; }
        public class EnableServicesResponseBodyFailedServices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Failed</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACVS</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E1BD3327-6BEE-53AD-8788-D892EB575962</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
