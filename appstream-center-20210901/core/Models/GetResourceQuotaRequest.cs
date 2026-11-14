// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourceQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The business region ID. If this parameter is omitted, the general quota that is not limited by region is queried, and the quotas of different regions are not added together. This parameter must be consistent with the business region of What to do next.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The billing method query condition. If this parameter is omitted, the general quota that is not limited by billing method is queried, and the quotas of different billing methods are not added together. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: subscription.</description></item>
        /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The product type. Set this parameter to the following fixed value when you call the operation:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: WUYING Cloud App.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The business resource type to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>AppInstanceGroup</c>: the quantity quota for delivery groups. Unit: groups.</description></item>
        /// <item><description><c>AppAuthUser</c>: the quantity quota for authorized users. Unit: users.</description></item>
        /// <item><description><c>PoolNodeAmount</c>: the quantity quota for purchased resource nodes. Unit: nodes.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppInstanceGroup</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
