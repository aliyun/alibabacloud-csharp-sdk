// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ModifyResourceQueueRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public List<ModifyResourceQueueRequestConfig> Config { get; set; }
        public class ModifyResourceQueueRequestConfig : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

        }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Leaf")]
        [Validation(Required=false)]
        public bool? Leaf { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ParentQueueId")]
        [Validation(Required=false)]
        public long? ParentQueueId { get; set; }

        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ResourcePoolId")]
        [Validation(Required=false)]
        public long? ResourcePoolId { get; set; }

    }

}
