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
        /// <para>The status of the Cloud Firewall VPC firewall switch module. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: The module is enabled.</description></item>
        /// <item><description><b>init</b>: The module is being enabled.</description></item>
        /// <item><description><b>closed</b>: The module is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of days during which protection is not enabled. This parameter is valid only when the module is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("UnprotectedDate")]
        [Validation(Required=false)]
        public long? UnprotectedDate { get; set; }

    }

}
