// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstancePatterns : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[This parameter is deprecated and replaced by cpu_architectures] The architectures of instance types.</para>
        /// </summary>
        [NameInMap("architectures")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Architectures { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[This parameter is deprecated] Specifies whether to include burstable instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Exclude</para>
        /// </summary>
        [NameInMap("burst_performance_option")]
        [Validation(Required=false)]
        [Obsolete]
        public string BurstPerformanceOption { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[This parameter is deprecated and replaced by cores] The number of vCores provided by the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("core")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Core { get; set; }

        /// <summary>
        /// <para>The number of vCPU cores for the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("cores")]
        [Validation(Required=false)]
        public long? Cores { get; set; }

        /// <summary>
        /// <para>The CPU architecture of the instance type.</para>
        /// </summary>
        [NameInMap("cpu_architectures")]
        [Validation(Required=false)]
        public List<string> CpuArchitectures { get; set; }

        /// <summary>
        /// <para>The instance type that you want to exclude.</para>
        /// </summary>
        [NameInMap("excluded_instance_types")]
        [Validation(Required=false)]
        public List<string> ExcludedInstanceTypes { get; set; }

        /// <summary>
        /// <para>The type of the instance.</para>
        /// </summary>
        [NameInMap("instance_categories")]
        [Validation(Required=false)]
        public List<string> InstanceCategories { get; set; }

        /// <summary>
        /// <para>The instance family level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseLevel</para>
        /// </summary>
        [NameInMap("instance_family_level")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The specified instance family.</para>
        /// </summary>
        [NameInMap("instance_type_families")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamilies { get; set; }

        /// <summary>
        /// <para>The maximum vCPU cores allowed for the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("max_cpu_cores")]
        [Validation(Required=false)]
        public long? MaxCpuCores { get; set; }

        /// <summary>
        /// <para>The maximum allowed memory size. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("max_memory_size")]
        [Validation(Required=false)]
        public float? MaxMemorySize { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[This parameter is deprecated] The maximum hourly price of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("max_price")]
        [Validation(Required=false)]
        [Obsolete]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// <para>The maximum allowed number of GPUs per instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("maximum_gpu_amount")]
        [Validation(Required=false)]
        public long? MaximumGpuAmount { get; set; }

        /// <summary>
        /// <para>The memory size of the instance type. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The minimum vCPU cores required for the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("min_cpu_cores")]
        [Validation(Required=false)]
        public long? MinCpuCores { get; set; }

        /// <summary>
        /// <para>The minimum required memory size. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("min_memory_size")]
        [Validation(Required=false)]
        public float? MinMemorySize { get; set; }

        /// <summary>
        /// <para>The minimum required number of IPv6 addresses per ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("minimum_eni_ipv6_address_quantity")]
        [Validation(Required=false)]
        public long? MinimumEniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum required number of IPv4 addresses per ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("minimum_eni_private_ip_address_quantity")]
        [Validation(Required=false)]
        public long? MinimumEniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum required number of elastic network interfaces (ENIs) per instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("minimum_eni_quantity")]
        [Validation(Required=false)]
        public long? MinimumEniQuantity { get; set; }

    }

}
