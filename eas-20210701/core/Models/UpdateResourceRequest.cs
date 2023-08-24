// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceRequest : TeaModel {
        [NameInMap("NodeMatchLabels")]
        [Validation(Required=false)]
        public Dictionary<string, string> NodeMatchLabels { get; set; }

        [NameInMap("NodeTolerations")]
        [Validation(Required=false)]
        public List<UpdateResourceRequestNodeTolerations> NodeTolerations { get; set; }
        public class UpdateResourceRequestNodeTolerations : TeaModel {
            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

    }

}
