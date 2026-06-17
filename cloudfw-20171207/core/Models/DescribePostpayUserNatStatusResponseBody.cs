// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayUserNatStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6B780BD6-282C-51A9-A8E6-59F636******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the NAT border firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>open</b>: The feature is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>init</b>: The feature is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>closed</b>: The feature is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of days that protection was disabled. This parameter is returned only when the NAT border firewall is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("UnprotectedDate")]
        [Validation(Required=false)]
        public long? UnprotectedDate { get; set; }

    }

}
