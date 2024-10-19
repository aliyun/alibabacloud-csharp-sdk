// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ValidateVpcConnectivityResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the API Gateway instance is connected to the port. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Connected")]
        [Validation(Required=false)]
        public bool? Connected { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance in the authorization is an ECS instance or an SLB instance when the instance ID in the authorization is an IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b></description></item>
        /// <item><description><b>SLB</b></description></item>
        /// <item><description><b>INVALID</b>: The instance type corresponding to the IP address is invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A591B5B-0EC2-5463-B8B8-1984AE3AEBF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
