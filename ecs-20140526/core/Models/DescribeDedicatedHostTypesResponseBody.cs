// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the dedicated host types.</para>
        /// </summary>
        [NameInMap("DedicatedHostTypes")]
        [Validation(Required=false)]
        public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypes DedicatedHostTypes { get; set; }
        public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypes : TeaModel {
            [NameInMap("DedicatedHostType")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostType> DedicatedHostType { get; set; }
            public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostType : TeaModel {
                /// <summary>
                /// <para>The number of cores per physical CPU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

                /// <summary>
                /// <para>The supported CPU overcommit ratio range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1-5</para>
                /// </summary>
                [NameInMap("CpuOverCommitRatioRange")]
                [Validation(Required=false)]
                public string CpuOverCommitRatioRange { get; set; }

                /// <summary>
                /// <para>The dedicated host type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddh.sn1ne</para>
                /// </summary>
                [NameInMap("DedicatedHostType")]
                [Validation(Required=false)]
                public string DedicatedHostType { get; set; }

                /// <summary>
                /// <para>The GPU model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gpu</para>
                /// </summary>
                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                /// <summary>
                /// <para>The number of local disks on a dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LocalStorageAmount")]
                [Validation(Required=false)]
                public int? LocalStorageAmount { get; set; }

                /// <summary>
                /// <para>The capacity of a local disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LocalStorageCapacity")]
                [Validation(Required=false)]
                public long? LocalStorageCapacity { get; set; }

                /// <summary>
                /// <para>The category of local disks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>local</para>
                /// </summary>
                [NameInMap("LocalStorageCategory")]
                [Validation(Required=false)]
                public string LocalStorageCategory { get; set; }

                /// <summary>
                /// <para>The memory size. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>112.0</para>
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public float? MemorySize { get; set; }

                /// <summary>
                /// <para>The number of physical GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PhysicalGpus")]
                [Validation(Required=false)]
                public int? PhysicalGpus { get; set; }

                /// <summary>
                /// <para>The number of physical CPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Sockets")]
                [Validation(Required=false)]
                public int? Sockets { get; set; }

                /// <summary>
                /// <para>Indicates whether the CPU overcommit ratio settings are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportCpuOverCommitRatio")]
                [Validation(Required=false)]
                public bool? SupportCpuOverCommitRatio { get; set; }

                /// <summary>
                /// <para>The ECS instance families supported by the dedicated host type.</para>
                /// </summary>
                [NameInMap("SupportedInstanceTypeFamilies")]
                [Validation(Required=false)]
                public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypeFamilies SupportedInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportedInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypeFamily { get; set; }

                }

                /// <summary>
                /// <para>The ECS instance types supported by the dedicated host type.</para>
                /// </summary>
                [NameInMap("SupportedInstanceTypesList")]
                [Validation(Required=false)]
                public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypesList SupportedInstanceTypesList { get; set; }
                public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypesList : TeaModel {
                    [NameInMap("SupportedInstanceTypesList")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypesList { get; set; }

                }

                /// <summary>
                /// <para>The total number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>56</para>
                /// </summary>
                [NameInMap("TotalVcpus")]
                [Validation(Required=false)]
                public int? TotalVcpus { get; set; }

                /// <summary>
                /// <para>The total number of vGPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalVgpus")]
                [Validation(Required=false)]
                public int? TotalVgpus { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FE5FF06-3A33-4658-8495-6445FC54E327</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
