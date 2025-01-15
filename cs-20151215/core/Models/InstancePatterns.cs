// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstancePatterns : TeaModel {
        /// <term><b>Obsolete</b></term>
        [NameInMap("architectures")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Architectures { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
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
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("core")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Core { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("cores")]
        [Validation(Required=false)]
        public long? Cores { get; set; }

        [NameInMap("cpu_architectures")]
        [Validation(Required=false)]
        public List<string> CpuArchitectures { get; set; }

        [NameInMap("excluded_instance_types")]
        [Validation(Required=false)]
        public List<string> ExcludedInstanceTypes { get; set; }

        [NameInMap("instance_categories")]
        [Validation(Required=false)]
        public List<string> InstanceCategories { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EnterpriseLevel</para>
        /// </summary>
        [NameInMap("instance_family_level")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("max_cpu_cores")]
        [Validation(Required=false)]
        public long? MaxCpuCores { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("max_memory_size")]
        [Validation(Required=false)]
        public float? MaxMemorySize { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("max_price")]
        [Validation(Required=false)]
        [Obsolete]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("min_cpu_cores")]
        [Validation(Required=false)]
        public long? MinCpuCores { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("min_memory_size")]
        [Validation(Required=false)]
        public float? MinMemorySize { get; set; }

    }

}
