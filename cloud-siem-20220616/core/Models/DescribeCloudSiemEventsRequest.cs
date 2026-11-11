// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCloudSiemEventsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the asset associated with the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The current page number. The value must be greater than or equal to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time for querying events, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The UUID of the entity associated with the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("EntityUuid")]
        [Validation(Required=false)]
        public string EntityUuid { get; set; }

        /// <summary>
        /// <para>The name of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS unusual log in</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The ID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The sort order of the event list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: Descending order.</description></item>
        /// <item><description>asc: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The field used to sort the event list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtModified: Sorts by event generation time (default).</description></item>
        /// <item><description>ThreatScore: Sorts by event threat score.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ThreatScore</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Cloud Threat Detection and Response (CTDR) is located. Select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets are in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Assets are in regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose view the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Current Alibaba Cloud account view.</description></item>
        /// <item><description>1: View of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The start time for querying events, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Unhandled.</description></item>
        /// <item><description>1: Processing.</description></item>
        /// <item><description>5: Failed.</description></item>
        /// <item><description>10: Handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The threat level of the event, in JSON array format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>serious: High.</description></item>
        /// <item><description>suspicious: Medium.</description></item>
        /// <item><description>remind: Low.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;serious&quot;,&quot;suspicious&quot;,&quot;remind&quot;]</para>
        /// </summary>
        [NameInMap("ThreadLevel")]
        [Validation(Required=false)]
        public List<string> ThreadLevel { get; set; }

    }

}
