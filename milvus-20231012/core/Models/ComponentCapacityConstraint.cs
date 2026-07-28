// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class ComponentCapacityConstraint : TeaModel {
        [NameInMap("componentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        [NameInMap("maxCapacity")]
        [Validation(Required=false)]
        public int? MaxCapacity { get; set; }

        [NameInMap("minCapacity")]
        [Validation(Required=false)]
        public int? MinCapacity { get; set; }

    }

}
