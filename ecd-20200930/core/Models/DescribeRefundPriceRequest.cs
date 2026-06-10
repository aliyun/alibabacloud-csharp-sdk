// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRefundPriceRequest : TeaModel {
        /// <summary>
        /// <para>A list of cloud desktop IDs. You can specify one or more IDs. The number of IDs (N) must be between 1 and 20.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>Refund type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RemainRefund</para>
        /// </summary>
        [NameInMap("RefundType")]
        [Validation(Required=false)]
        public string RefundType { get; set; }

        /// <summary>
        /// <para>Region ID. Call <a href="~~DescribeRegions~~">DescribeRegions</a> to get a list of regions supported by WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

    }

}
