// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9178CB86-285F-5679-A30A-3B3F007E4206</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the ports that can be used by a hybrid cloud cluster.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public DescribeHybridCloudUserResponseBodyUserInfo UserInfo { get; set; }
        public class DescribeHybridCloudUserResponseBodyUserInfo : TeaModel {
            /// <summary>
            /// <para>The HTTP ports. The value is a string. If multiple ports are returned, the value is in the <b>port1,port2,port3</b> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80,8080</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            /// <summary>
            /// <para>The HTTPS ports. The value is a string. If multiple ports are returned, the value is in the <b>port1,port2,port3</b> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8443,443</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

        }

    }

}
