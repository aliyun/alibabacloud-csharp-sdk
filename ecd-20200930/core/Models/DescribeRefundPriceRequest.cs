// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRefundPriceRequest : TeaModel {
        /// <summary>
        /// <para>ID of cloud computer N. Valid values of N: 1 to 20.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The unsubscription type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RemainRefund: refunds the remaining balance and releases resources.</description></item>
        /// <item><description>RenewRefund: refunds only the renewal fee and adjusts the expiration date accordingly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RemainRefund</para>
        /// </summary>
        [NameInMap("RefundType")]
        [Validation(Required=false)]
        public string RefundType { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
