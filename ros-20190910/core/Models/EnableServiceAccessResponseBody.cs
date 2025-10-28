// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class EnableServiceAccessResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>23045A5D-720E-5D11-A752-E1568F725C93</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceAccessInfo")]
        [Validation(Required=false)]
        public EnableServiceAccessResponseBodyServiceAccessInfo ServiceAccessInfo { get; set; }
        public class EnableServiceAccessResponseBodyServiceAccessInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ENABLED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
