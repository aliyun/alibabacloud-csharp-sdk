// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstancePatterns : TeaModel {
        [NameInMap("architectures")]
        [Validation(Required=false)]
        public List<string> Architectures { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Exclude</para>
        /// </summary>
        [NameInMap("burst_performance_option")]
        [Validation(Required=false)]
        public string BurstPerformanceOption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("core")]
        [Validation(Required=false)]
        public long? Core { get; set; }

        [NameInMap("excluded_instance_types")]
        [Validation(Required=false)]
        public List<string> ExcludedInstanceTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EnterpriseLevel</para>
        /// </summary>
        [NameInMap("instance_family_level")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("max_price")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

    }

}
