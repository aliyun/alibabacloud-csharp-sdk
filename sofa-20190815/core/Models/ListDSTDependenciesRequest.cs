// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTDependenciesRequest : TeaModel {
        [NameInMap("DependencyType")]
        [Validation(Required=false)]
        public string DependencyType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Relations")]
        [Validation(Required=false)]
        public List<ListDSTDependenciesRequestRelations> Relations { get; set; }
        public class ListDSTDependenciesRequestRelations : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ResourceInfo")]
        [Validation(Required=false)]
        public List<ListDSTDependenciesRequestResourceInfo> ResourceInfo { get; set; }
        public class ListDSTDependenciesRequestResourceInfo : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
