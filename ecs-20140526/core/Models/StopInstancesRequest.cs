// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The batch operation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AllTogether: In this mode, if all instances are stopped, a success message is returned. If an instance fails the verification, all instances fail to stop and an error message is returned.</description></item>
        /// <item><description>SuccessFirst: In this mode, each instance is separately stopped. The response contains the operation results for each instance.</description></item>
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
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and instance status. If the request fails the dry run, an error message is returned. If the request passes the dry run, <c>DRYRUN.SUCCESS</c> is returned.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set <c>BatchOptimization</c> to <c>SuccessFirst</c> and <c>DryRun</c> to true, only <c>DRYRUN.SUCCESS</c> is returned, regardless of whether the request passes the dry run.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>false: performs a dry run and performs the actual request. If the request passes the dry run, instances are stopped.</description></item>
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
        /// <para>Specifies whether to forcefully stop instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true. This operation is equivalent to the typical power-off operation. Cache data that is not written to storage devices on instances is lost.</description></item>
        /// <item><description>false.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// <para>The IDs of instances.</para>
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
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

        /// <summary>
        /// <para>The stop mode of the pay-as-you-go instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>StopCharging: economical mode. For information about how <c>StopCharging</c> takes effect, see the &quot;Prerequisites&quot; section in <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</description></item>
        /// <item><description>KeepCharging: standard mode. After the instance is stopped in standard mode, you continue to be charged for it.</description></item>
        /// </list>
        /// <para>Default value: If the prerequisites required for enabling economical mode are met and you have enabled the mode in the ECS console, the default value is <a href="~~63353#default~~">StopCharging</a>. For more information, see the &quot;Enable economical mode&quot; section in <c>Economical mode</c>. Otherwise, the default value is <c>KeepCharging</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KeepCharging</para>
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
