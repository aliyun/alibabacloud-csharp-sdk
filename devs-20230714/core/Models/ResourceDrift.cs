// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ResourceDrift : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("change")]
        [Validation(Required=false)]
        public ResourceDriftChange Change { get; set; }
        public class ResourceDriftChange : TeaModel {
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<string> Actions { get; set; }

            [NameInMap("after")]
            [Validation(Required=false)]
            public object After { get; set; }

            [NameInMap("before")]
            [Validation(Required=false)]
            public object Before { get; set; }

        }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
