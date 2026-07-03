// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCloudSiemEventsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the asset that is associated with the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c740667-80b2-476d-8924-2e706feb****</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The UUID of the entity that is associated with the event.</para>
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
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>desc: descending</para>
        /// </description></item>
        /// <item><description><para>asc: ascending</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The field to sort the event list by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtModified: Sorts by modification time. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>ThreatScore: Sorts by threat score.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ThreatScore</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center of Threat Analysis &amp; Response is located. Select the region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in regions outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member. The administrator can use this ID to view the data of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts that are managed by the administrator account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The start time of the query. This value is a UNIX timestamp. Unit: milliseconds.</para>
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
        /// <item><description><para>0: unhandled</para>
        /// </description></item>
        /// <item><description><para>1: in progress</para>
        /// </description></item>
        /// <item><description><para>5: failed</para>
        /// </description></item>
        /// <item><description><para>10: handled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The threat level of the event. The value is a JSON array. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>serious: high</para>
        /// </description></item>
        /// <item><description><para>suspicious: medium</para>
        /// </description></item>
        /// <item><description><para>remind: low</para>
        /// </description></item>
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
