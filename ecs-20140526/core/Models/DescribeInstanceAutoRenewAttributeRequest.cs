// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The instance IDs. You can specify up to 100 subscription instances at a time. Separate multiple instance IDs with commas.</para>
        /// <remarks>
        /// <para>You must specify either <c>InstanceId</c> or <c>RenewalStatus</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp18x3z4hc7bixhx****,i-bp1g6zv0ce8oghu7****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Minimum value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The auto-renewal status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AutoRenewal: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para>Normal: Auto-renewal is disabled.</para>
        /// </description></item>
        /// <item><description><para>NotRenewal: The instance will not be renewed. The system does not send expiration reminders but sends a non-renewal reminder three days before the expiration date. To renew an ECS instance with this status, you must first call <a href="https://help.aliyun.com/document_detail/52843.html">ModifyInstanceAutoRenewAttribute</a> to change its status to <c>Normal</c>. You can then manually renew the instance or enable auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
