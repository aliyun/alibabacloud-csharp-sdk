// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRenewalPriceRequest : TeaModel {
        /// <summary>
        /// <para>The unified expiration day. If you specify this parameter, the system queries the price for renewing the instance until the unified expiration day. Valid values: 1 to 28.</para>
        /// <para>For more information about the unified expiration day feature, see <a href="https://help.aliyun.com/document_detail/108486.html">Unify Instance Expiration Dates</a>.</para>
        /// <remarks>
        /// <para>You cannot specify both the renewal duration parameters (<c>Period</c> and <c>PeriodUnit</c>) and the unified expiration day parameter (<c>ExpectedRenewDay</c>) at the same time.</para>
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
        /// <para>Specifies the renewal duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>When the <c>PriceUnit</c> parameter is set to <c>Month</c>: 1 to 9.</para>
        /// </description></item>
        /// <item><description><para>When the <c>PriceUnit</c> parameter is set to <c>Year</c>: 1 to 3.</para>
        /// </description></item>
        /// </list>
        /// <para>Default Value: 1.</para>
        /// <remarks>
        /// <para>You cannot specify both the renewal duration parameters (<c>Period</c> and <c>PeriodUnit</c>) and the unified expiration day parameter (<c>ExpectedRenewDay</c>) at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>Specifies the renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Month: The renewal period is one month.</para>
        /// </description></item>
        /// <item><description><para>Year: The renewal period is one year.</para>
        /// </description></item>
        /// </list>
        /// <para>Default Value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// <para>The Region ID of the instance. You can invoke <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud Regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource ID for which to query the renewal price. When the parameter <c>ResourceType</c> is set to <c>instance</c>, <c>ResourceId</c> can be interpreted as <c>InstanceId</c>.</para>
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
        /// <para>The resource type for which to query the renewal price. Valid value: instance.</para>
        /// <para>Default Value: instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
