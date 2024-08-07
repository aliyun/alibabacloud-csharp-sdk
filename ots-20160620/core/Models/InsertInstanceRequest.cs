// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ots20160620.Models
{
    public class InsertInstanceRequest : TeaModel {
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TagInfo")]
        [Validation(Required=false)]
        public List<InsertInstanceRequestTagInfo> TagInfo { get; set; }
        public class InsertInstanceRequestTagInfo : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
