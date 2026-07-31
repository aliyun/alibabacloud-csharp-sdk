// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTasksRequest : TeaModel {
        /// <summary>
        /// <para>The end of the creation time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
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
        /// <para>The page number of the results.</para>
        /// <para>Minimum value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource IDs. Valid values of N: 1 to 100.</para>
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
        /// <para>The beginning of the creation time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-23T15:10:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the API operation associated with the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ImportImage: import an image.</description></item>
        /// <item><description>ExportImage: export an image.</description></item>
        /// <item><description>RedeployInstance: redeploy an ECS instance.</description></item>
        /// <item><description>ModifyDiskSpec: change the cloud disk type.</description></item>
        /// <item><description>ArchiveSnapshot: archive a snapshot.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ImportImage</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The task group ID.</para>
        /// <remarks>
        /// <para>This parameter is in invitational preview. When this parameter is specified, other query conditions do not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>g-2ze2op2grqpclwu7****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("TaskGroupId")]
        [Validation(Required=false)]
        public string TaskGroupId { get; set; }

        /// <summary>
        /// <para>The task IDs. You can specify up to 100 task IDs at a time. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-bp1hvgwromzv32iq****,t-bp179lofu2pv768w****</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Finished: The task is complete.</description></item>
        /// <item><description>Processing: The task is running.</description></item>
        /// <item><description>Failed: The task has failed.</description></item>
        /// </list>
        /// <para>Default value: null.</para>
        /// <remarks>
        /// <para>Only tasks in the Finished, Processing, or Failed state can be queried. Other values do not take effect.</para>
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
