// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRenewalPriceRequest : TeaModel {
        /// <summary>
        /// <para>The synchronized expiration date. If you specify this parameter, the price for renewing a specified instance to the specified synchronized expiration date is queried. Valid values: 1 to 28.</para>
        /// <para>For information about how to synchronize the expiration dates of instances, see <a href="https://help.aliyun.com/document_detail/108486.html">Synchronize the expiration dates of instances</a>.</para>
        /// <remarks>
        /// <para>The renewal period-related parameter pair (<c>Period</c> and <c>PeriodUnit</c>) and the <c>ExpectedRenewDay</c> parameter are mutually exclusive.</para>
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
        /// <para>The renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when the <c>PriceUnit</c> parameter is set to <c>Month</c>: 1, 2, 3, 4, 5, 6, 7, 8, and 9.</description></item>
        /// <item><description>Valid values when the <c>PriceUnit</c> parameter is set to <c>Year</c>: 1, 2, 3.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// <remarks>
        /// <para>The renewal period-related parameter pair (<c>Period</c> and <c>PeriodUnit</c>) and the <c>ExpectedRenewDay</c> parameter are mutually exclusive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
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
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent list of regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource. If the <c>ResourceType</c> parameter is set to<c> instance</c>, the value of the <c>ResourceId</c> parameter is the ID of the specified instance.``</para>
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
        /// <para>The type of the resource. Set the value to instance.</para>
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
