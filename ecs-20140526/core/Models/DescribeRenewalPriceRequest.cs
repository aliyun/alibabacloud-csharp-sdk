// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRenewalPriceRequest : TeaModel {
        /// <summary>
        /// <para>The unified expiration date. After you specify this parameter, the price for renewing the instance to the unified expiration date is returned. Valid values: 1 to 28.</para>
        /// <para>For more information about the unified expiration date feature, see <a href="https://help.aliyun.com/document_detail/108486.html">Settings for instance expires</a>.</para>
        /// <remarks>
        /// <para>The renewal duration parameters (<c>Period</c> and <c>PeriodUnit</c>) and the unified expiration date parameter (<c>ExpectedRenewDay</c>) cannot be set at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ExpectedRenewDay")]
        [Validation(Required=false)]
        public int? ExpectedRenewDay { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The renewal duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <c>PriceUnit</c> is set to <c>Month</c>: 1 to 9.</description></item>
        /// <item><description>When <c>PriceUnit</c> is set to <c>Year</c>: 1 to 3.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// <remarks>
        /// <para>The renewal duration parameters (<c>Period</c> and <c>PeriodUnit</c>) and the unified expiration date parameter (<c>ExpectedRenewDay</c>) cannot be set at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month: the renewal duration is measured in months.</description></item>
        /// <item><description>Year: the renewal duration is measured in years.</description></item>
        /// </list>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource whose renewal price you want to query. When <c>ResourceType</c> is set to <c>instance</c>, <c>ResourceId</c> is equivalent to <c>InstanceId</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1f2o4ldh8l29zv****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the resource whose renewal price you want to query. Valid values: instance.</para>
        /// <para>Default value: instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
