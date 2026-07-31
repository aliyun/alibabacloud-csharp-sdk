// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The batch operation pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AllTogether: In this pattern, if all instances are started, a success message is returned. If any instance fails validation, all instances fail to start and a failed message is returned.</para>
        /// </description></item>
        /// <item><description><para>SuccessFirst: In this pattern, each instance is started separately. The response contains the operation result for each instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: AllTogether.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AllTogether</para>
        /// </summary>
        [NameInMap("BatchOptimization")]
        [Validation(Required=false)]
        public string BatchOptimization { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: performs only a dry run. The system checks the required parameters, request format, and instance status. If the check fails, the corresponding fault is returned. If the check succeeds, <c>DRYRUN.SUCCESS</c> is returned.</para>
        /// <remarks>
        /// <para>If the BatchOptimization parameter is set to <c>SuccessFirst</c>, the dry run with <c>DryRun=true</c> returns only <c>DRYRUN.SUCCESS</c>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: sends a Normal request. After the check succeeds, the instances are started.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The list of instance IDs. Valid values of the array length: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instances. You can invoke <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
