// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class ApiMcpServerValidateHclRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>variable &quot;name&quot; {
        ///   default = &quot;terraform-example&quot;
        /// }</para>
        /// <para>provider &quot;alicloud&quot; {
        ///   region = &quot;cn-beijing&quot;
        /// }</para>
        /// <para>resource &quot;alicloud_vpc&quot; &quot;default&quot; {
        ///   ipv6_isp    = &quot;BGP&quot;
        ///   description = &quot;test&quot;
        ///   cidr_block  = &quot;10.0.0.0/8&quot;
        ///   vpc_name    = var.name
        ///   enable_ipv6 = true
        /// }</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
