// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSlbRequest : TeaModel {
        /// <summary>
        /// <para>The type of the IP addresses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Internet: Users can connect to the SLB instance over the Internet.</description></item>
        /// <item><description>Intranet: Users can connect to the SLB instance over the internal network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The type of the SLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>clb: Classic Load Balancer (CLB)</description></item>
        /// <item><description>alb: Application Load Balancer (ALB)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("SlbType")]
        [Validation(Required=false)]
        public string SlbType { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1f90rfybszjogyw****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
