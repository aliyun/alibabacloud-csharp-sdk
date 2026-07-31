// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RebootInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The batch operation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AllTogether: In this mode, a success message is returned if all instances are restarted. If any instance fails validation, all instances fail to restart and an error message is returned.</para>
        /// </description></item>
        /// <item><description><para>SuccessFirst: In this mode, each instance is restarted separately. The response includes the operation result for each instance.</para>
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
        /// <item><description><para>true: performs only a dry run without restarting the instance. The system checks the required parameters, request format, and instance status. If the check fails, the corresponding error is returned. If the check passes, <c>DRYRUN.SUCCESS</c> is returned.</para>
        /// <remarks>
        /// <para>If the BatchOptimization parameter is set to <c>SuccessFirst</c>, the dry run result for <c>DryRun=true</c> returns only <c>DRYRUN.SUCCESS</c>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: performs a dry run and sends the request. After the check passes, the instance is restarted.</para>
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
        /// <para>Specifies whether to force restart the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: forces a restart. This is equivalent to a power-off operation. Cached data that has not been written to storage devices is lost.</para>
        /// </description></item>
        /// <item><description><para>false: performs a normal restart.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceReboot")]
        [Validation(Required=false)]
        public bool? ForceReboot { get; set; }

        /// <summary>
        /// <para>The instance ID array. Array length: 1 to 100.</para>
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
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
