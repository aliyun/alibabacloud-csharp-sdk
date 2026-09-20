// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeMultiZoneAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prepaid: subscription.</description></item>
        /// <item><description>Postpaid: pay-as-you-go.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The zone combination. If this parameter is not specified, all zone combinations in the region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-bef-aliyun</para>
        /// </summary>
        [NameInMap("ZoneCombination")]
        [Validation(Required=false)]
        public string ZoneCombination { get; set; }

    }

}
