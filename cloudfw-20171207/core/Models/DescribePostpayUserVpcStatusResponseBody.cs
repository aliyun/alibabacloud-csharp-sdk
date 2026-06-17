// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayUserVpcStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7447795A-39AB-52CB-8F92-128DF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the VPC border firewall for Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>open</b>: The firewall is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>init</b>: The firewall is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>closed</b>: The firewall is disabled.</para>
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
        /// <para>The number of days that protection was disabled. This parameter is valid only when the firewall is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("UnprotectedDate")]
        [Validation(Required=false)]
        public long? UnprotectedDate { get; set; }

    }

}
