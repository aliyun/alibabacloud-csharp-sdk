// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAvailableInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The end time when the specified instance is created. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T12:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time when the specified instance is created. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T12:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2016-05-23T12:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTimeEnd")]
        [Validation(Required=false)]
        public string EndTimeEnd { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2016-05-23T12:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-05-23T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTimeStart")]
        [Validation(Required=false)]
        public string EndTimeStart { get; set; }

        /// <summary>
        /// <para>The ID of the instance. Separate multiple IDs with commas (,). You can specify a maximum of 100 IDs.</para>
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
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The code of the service. You can query the service code by calling the <b>QueryProductList</b> operation or viewing <b>Codes of Alibaba Cloud services</b>.</para>
        /// <remarks>
        /// <para>This parameter cannot be left empty if the region is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The renewal status of the specified instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewal: The instance is automatically renewed.</description></item>
        /// <item><description>ManualRenewal: The instance is manually renewed.</description></item>
        /// <item><description>NotRenewal: The instance is not renewed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("RenewStatus")]
        [Validation(Required=false)]
        public string RenewStatus { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
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
