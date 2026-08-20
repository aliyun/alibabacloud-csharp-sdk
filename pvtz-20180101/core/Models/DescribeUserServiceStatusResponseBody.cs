// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeUserServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99626905-678A-4E8A-984E-6AEB09993996</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service status of the current user:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CLOSED</b>: The service is not activated.</para>
        /// </description></item>
        /// <item><description><para><b>OPENED</b>: The service is activated.</para>
        /// </description></item>
        /// <item><description><para><b>IN_DEBT</b>: The service has an overdue payment.</para>
        /// </description></item>
        /// <item><description><para><b>IN_DEBT_OVER_DUE</b>: The service is suspended due to an overdue payment.</para>
        /// </description></item>
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
