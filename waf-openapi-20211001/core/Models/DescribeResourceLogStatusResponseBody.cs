// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceLogStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DABF8AB-2321-5F8D-A8D7-922D757FBFFE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The log status information of protected objects.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeResourceLogStatusResponseBodyResult> Result { get; set; }
        public class DescribeResourceLogStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The name of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-wewbb23dfsetetcic****</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>Indicates whether log collection is enabled for the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Log collection is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Log collection is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

    }

}
