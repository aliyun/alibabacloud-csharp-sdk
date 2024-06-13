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

        [NameInMap("burst_performance_option")]
        [Validation(Required=false)]
        public string BurstPerformanceOption { get; set; }

        [NameInMap("core")]
        [Validation(Required=false)]
        public long? Core { get; set; }

        [NameInMap("excluded_instance_types")]
        [Validation(Required=false)]
        public List<string> ExcludedInstanceTypes { get; set; }

        [NameInMap("instance_family_level")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        [NameInMap("max_price")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        [NameInMap("memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

    }

}
