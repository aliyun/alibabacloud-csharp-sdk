// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ResourceInstance : TeaModel {
        /// <summary>
        /// <para>The system architecture of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arm64</para>
        /// </summary>
        [NameInMap("Arch")]
        [Validation(Required=false)]
        public string Arch { get; set; }

        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The billing method for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-05T22:51:32Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-05T22:51:32Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The number of CPUs for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("InstanceCpuCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCount { get; set; }

        /// <summary>
        /// <para>The number of GPUs for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InstanceGpuCount")]
        [Validation(Required=false)]
        public int? InstanceGpuCount { get; set; }

        /// <summary>
        /// <para>The VRAM size of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0G</para>
        /// </summary>
        [NameInMap("InstanceGpuMemory")]
        [Validation(Required=false)]
        public string InstanceGpuMemory { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-i-1800z74n30kao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11.227.XX.XX</para>
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// <para>The memory size of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192M</para>
        /// </summary>
        [NameInMap("InstanceMemory")]
        [Validation(Required=false)]
        public string InstanceMemory { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas01122713204*****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The lifecycle phase of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>succeeded</para>
        /// </summary>
        [NameInMap("InstancePhase")]
        [Validation(Required=false)]
        public string InstancePhase { get; set; }

        /// <summary>
        /// <para>The status of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The system disk size of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("InstanceSystemDiskSize")]
        [Validation(Required=false)]
        public int? InstanceSystemDiskSize { get; set; }

        /// <summary>
        /// <para>The IP address of the instance in a dedicated network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("InstanceTenantIp")]
        [Validation(Required=false)]
        public string InstanceTenantIp { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.s6-c1m2.xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The number of CPUs in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4</para>
        /// </summary>
        [NameInMap("InstanceUsedCpu")]
        [Validation(Required=false)]
        public float? InstanceUsedCpu { get; set; }

        /// <summary>
        /// <para>The number of GPUs in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InstanceUsedGpu")]
        [Validation(Required=false)]
        public float? InstanceUsedGpu { get; set; }

        /// <summary>
        /// <para>The amount of VRAM in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>470M</para>
        /// </summary>
        [NameInMap("InstanceUsedGpuMemory")]
        [Validation(Required=false)]
        public string InstanceUsedGpuMemory { get; set; }

        /// <summary>
        /// <para>The amount of memory in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000M</para>
        /// </summary>
        [NameInMap("InstanceUsedMemory")]
        [Validation(Required=false)]
        public string InstanceUsedMemory { get; set; }

        /// <summary>
        /// <para>The labels of the instance.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<ResourceInstanceLabels> Labels { get; set; }
        public class ResourceInstanceLabels : TeaModel {
            /// <summary>
            /// <para>The label key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }

            /// <summary>
            /// <para>The label value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("LabelValue")]
            [Validation(Required=false)]
            public string LabelValue { get; set; }

        }

        /// <summary>
        /// <para>The operator who performed the last cordon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24340xxxxxxxx</para>
        /// </summary>
        [NameInMap("LastCordonOperator")]
        [Validation(Required=false)]
        public string LastCordonOperator { get; set; }

        /// <summary>
        /// <para>The reason for the last cordon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operating</para>
        /// </summary>
        [NameInMap("LastCordonReason")]
        [Validation(Required=false)]
        public string LastCordonReason { get; set; }

        /// <summary>
        /// <para>The region of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-xxxxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
