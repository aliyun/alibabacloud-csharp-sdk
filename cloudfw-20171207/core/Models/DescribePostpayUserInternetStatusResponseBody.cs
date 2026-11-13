// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayUserInternetStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DC783F1-B3A7-578D-8A63-*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the Internet Border switch module in Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: The module is enabled.</description></item>
        /// <item><description><b>init</b>: The module is being enabled.</description></item>
        /// <item><description><b>closed</b>: The module is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of days that protection is not enabled. This parameter is valid only when the module is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("UnprotectedDate")]
        [Validation(Required=false)]
        public long? UnprotectedDate { get; set; }

    }

}
