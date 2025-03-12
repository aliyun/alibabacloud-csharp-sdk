// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateSecurityIpGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP addresses or CIDR blocks in the IP address whitelist group.<br>The return values of SecurityIps are strings that are separated with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform.<br>Set the value to <b>CreateSecurityIpGroup</b>.</para>
        /// </summary>
        [NameInMap("SecurityIpGroup")]
        [Validation(Required=false)]
        public CreateSecurityIpGroupResponseBodySecurityIpGroup SecurityIpGroup { get; set; }
        public class CreateSecurityIpGroupResponseBodySecurityIpGroup : TeaModel {
            /// <summary>
            /// <pre><c>http(s)://[Endpoint]/?Action=CreateSecurityIpGroup
            /// &amp;InstanceId=ob317v4uif****
            /// &amp;SecurityIps=192.168.1.1,192.168.0.0.1/8
            /// &amp;SecurityIpGroupName=pay_online
            /// &amp;Common request parameters
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>You can call this operation to create an IP address whitelist group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pay_online</para>
            /// </summary>
            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.1.1,192.168.0.0.1/8</para>
            /// </summary>
            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public string SecurityIps { get; set; }

        }

    }

}
