// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class CreateResourcePoolRequest : TeaModel {
        [NameInMap("Active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public List<CreateResourcePoolRequestConfig> Config { get; set; }
        public class CreateResourcePoolRequestConfig : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            [NameInMap("configType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("PoolType")]
        [Validation(Required=false)]
        public string PoolType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("YarnSiteConfig")]
        [Validation(Required=false)]
        public string YarnSiteConfig { get; set; }

    }

}
