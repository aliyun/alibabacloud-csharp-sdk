// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateTenantSecurityIpGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the whitelist group.</para>
        /// </summary>
        [NameInMap("SecurityIpGroup")]
        [Validation(Required=false)]
        public CreateTenantSecurityIpGroupResponseBodySecurityIpGroup SecurityIpGroup { get; set; }
        public class CreateTenantSecurityIpGroupResponseBodySecurityIpGroup : TeaModel {
            /// <summary>
            /// <para>The ID of the OceanBase cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the whitelist group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>paytest</para>
            /// </summary>
            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

            /// <summary>
            /// <para>The list of IP addresses in the IP address whitelist group.   </para>
            /// <para>It is a string separated by commas, and each object is an IP address or CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.***.<em>.</em></para>
            /// </summary>
            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public string SecurityIps { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t4louaeei****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
