// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurchaseRatePlanResponseBody : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-ads11w</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30423A7F-A83D-1E24-B80E-86DD25790758</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
