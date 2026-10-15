// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAvailableInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the creation time range. Specify the time in the ISO 8601 standard in the UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T12:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the creation time range. Specify the time in the ISO 8601 standard in the UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T12:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The end time of the expiration time range. Specify the time in the ISO 8601 standard in the UTC format. Example: 2016-05-23T12:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTimeEnd")]
        [Validation(Required=false)]
        public string EndTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the expiration time range. Specify the time in the ISO 8601 standard in the UTC format. Example: 2016-05-23T12:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTimeStart")]
        [Validation(Required=false)]
        public string EndTimeStart { get; set; }

        /// <summary>
        /// <para>The instance IDs. Separate multiple IDs with commas. You can specify up to 100 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceIDs")]
        [Validation(Required=false)]
        public string InstanceIDs { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product code. You can call the <b>QueryProductList</b> operation to query product codes.</para>
        /// <remarks>
        /// <para>If the region is specified, this parameter cannot be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The renewal status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewal: auto-renewal.</description></item>
        /// <item><description>ManualRenewal: manual renewal.</description></item>
        /// <item><description>NotRenewal: no renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("RenewStatus")]
        [Validation(Required=false)]
        public string RenewStatus { get; set; }

        /// <summary>
        /// <para>The subscription type.</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription.</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
