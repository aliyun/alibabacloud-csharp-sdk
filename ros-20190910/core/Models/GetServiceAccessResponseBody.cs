// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetServiceAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DEFE672-690F-54C1-B42A-8E78E640BE07</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The trusted service details.</para>
        /// </summary>
        [NameInMap("ServiceAccessInfo")]
        [Validation(Required=false)]
        public GetServiceAccessResponseBodyServiceAccessInfo ServiceAccessInfo { get; set; }
        public class GetServiceAccessResponseBodyServiceAccessInfo : TeaModel {
            /// <summary>
            /// <para>Trusted service status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
