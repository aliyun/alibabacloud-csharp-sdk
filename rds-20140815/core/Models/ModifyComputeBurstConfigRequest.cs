// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyComputeBurstConfigRequest : TeaModel {
        /// <summary>
        /// <para>Set this parameter to <b>disabled</b> to disable the committed serverless feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("BurstStatus")]
        [Validation(Required=false)]
        public string BurstStatus { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCziJZNwH****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The CPU utilization threshold for elastic <b>scale-out</b>. Valid values: 60 to 90. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("CpuEnlargeThreshold")]
        [Validation(Required=false)]
        public string CpuEnlargeThreshold { get; set; }

        /// <summary>
        /// <para>The CPU utilization threshold for elastic <b>scale-in</b>. Valid values: 30 to 55. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("CpuShrinkThreshold")]
        [Validation(Required=false)]
        public string CpuShrinkThreshold { get; set; }

        /// <summary>
        /// <para>A reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("CrontabJobId")]
        [Validation(Required=false)]
        public string CrontabJobId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-2ze63v2p3o3k****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The memory utilization threshold for elastic <b>scale-out</b>. Valid values: 60 to 90. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("MemoryEnlargeThreshold")]
        [Validation(Required=false)]
        public string MemoryEnlargeThreshold { get; set; }

        /// <summary>
        /// <para>The memory utilization threshold for elastic <b>scale-in</b>. Valid values: 30 to 55. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MemoryShrinkThreshold")]
        [Validation(Required=false)]
        public string MemoryShrinkThreshold { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The maximum number of CPUs for elastic scale-out. The value can be up to twice the initial CPU configuration of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleMaxCpus")]
        [Validation(Required=false)]
        public string ScaleMaxCpus { get; set; }

        /// <summary>
        /// <para>The maximum memory for elastic scale-out. The value can be up to twice the initial memory configuration of the instance. Unit: GB. The value is adjusted in increments of 2 GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ScaleMaxMemory")]
        [Validation(Required=false)]
        public string ScaleMaxMemory { get; set; }

        [NameInMap("ScaleMaxRcu")]
        [Validation(Required=false)]
        public double? ScaleMaxRcu { get; set; }

        [NameInMap("ScaleMinRcu")]
        [Validation(Required=false)]
        public double? ScaleMinRcu { get; set; }

        /// <summary>
        /// <para>The specified time at which the modification takes effect. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c> (UTC).</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SwitchTimeMode</b> is set to <b>2</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-06T09:24:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The effective policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The modification takes effect immediately.</description></item>
        /// <item><description><b>1</b>: The modification takes effect during the maintenance window. You can call the <b>ModifyDBInstanceMaintainTime</b> operation to modify the maintenance window.</description></item>
        /// <item><description><b>2</b>: The modification takes effect at a specified point in time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// <para>A reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
