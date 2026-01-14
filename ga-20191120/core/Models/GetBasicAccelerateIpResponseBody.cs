// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetBasicAccelerateIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The accelerated IP address of the basic GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.132.XX.XX</para>
        /// </summary>
        [NameInMap("AccelerateIpAddress")]
        [Validation(Required=false)]
        public string AccelerateIpAddress { get; set; }

        /// <summary>
        /// <para>The ID of the accelerated IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gaip-bp1****</para>
        /// </summary>
        [NameInMap("AccelerateIpId")]
        [Validation(Required=false)]
        public string AccelerateIpId { get; set; }

        /// <summary>
        /// <para>The ID of the basic GA instance to which the queried accelerated IP address belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The ID of the acceleration region of the basic GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ips-bp11r5jb8ogp122xl****</para>
        /// </summary>
        [NameInMap("IpSetId")]
        [Validation(Required=false)]
        public string IpSetId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the accelerated IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>active</b>: The accelerated IP address is available.</description></item>
        /// <item><description><b>binding</b>: The accelerated IP address is being associated.</description></item>
        /// <item><description><b>bound</b>: The accelerated IP address is associated.</description></item>
        /// <item><description><b>unbinding</b>: The accelerated IP address is being disassociated.</description></item>
        /// <item><description><b>deleting</b>: The GA instance is being deleted.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the accelerated IP address is being created, this parameter is not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
