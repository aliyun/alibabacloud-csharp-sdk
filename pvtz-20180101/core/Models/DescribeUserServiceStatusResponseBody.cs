// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeUserServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99626905-678A-4E8A-984E-6AEB09993996</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Current user\&quot;s service status:</para>
        /// <list type="bullet">
        /// <item><description><b>CLOSED</b>: Not activated</description></item>
        /// <item><description><b>OPENED</b>: Activated</description></item>
        /// <item><description><b>IN_DEBT</b>: Overdue payment</description></item>
        /// <item><description><b>IN_DEBT_OVER_DUE</b>: Payment overdue</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPENED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
