// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTasksRequest : TeaModel {
        /// <summary>
        /// <para>The end point of the time period for which to query created tasks. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-23T15:16:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Page start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the task. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of resource N that is associated with the task. Valid values of N: 1 to 100.</para>
        /// <list type="bullet">
        /// <item><description>If TaskAction is set to ImportImage or ExportImage, set the resource ID to an image ID.</description></item>
        /// <item><description>If TaskAction is set to RedeployInstance, set the resource ID to an Elastic Compute Service (ECS) instance ID.</description></item>
        /// <item><description>If TaskAction is set to ModifyDiskSpec, set the resource ID to a disk ID.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start point of the time period for which to query created tasks. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-23T15:10:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the operation that generates the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ImportImage</description></item>
        /// <item><description>ExportImage</description></item>
        /// <item><description>RedeployInstance</description></item>
        /// <item><description>ModifyDiskSpec</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ImportImage</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The ID of the task. You can specify up to 100 task IDs at a time. Separate the task IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-bp1hvgwromzv32iq****,t-bp179lofu2pv768w****</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

        /// <summary>
        /// <para>The state of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Finished</description></item>
        /// <item><description>Processing</description></item>
        /// <item><description>Failed</description></item>
        /// </list>
        /// <para>This parameter is empty by default.</para>
        /// <remarks>
        /// <para> The system only retrieves tasks in the Finished, Processing, and Failed states and ignores other values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
