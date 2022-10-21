// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ComponentLayout : TeaModel {
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public ComponentLayoutNodeSelector NodeSelector { get; set; }
        public class ComponentLayoutNodeSelector : TeaModel {
            [NameInMap("NodeEndIndex")]
            [Validation(Required=false)]
            public int? NodeEndIndex { get; set; }

            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            [NameInMap("NodeGroupIndex")]
            [Validation(Required=false)]
            public int? NodeGroupIndex { get; set; }

            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            [NameInMap("NodeGroupTypes")]
            [Validation(Required=false)]
            public List<string> NodeGroupTypes { get; set; }

            [NameInMap("NodeNames")]
            [Validation(Required=false)]
            public List<string> NodeNames { get; set; }

            [NameInMap("NodeSelectType")]
            [Validation(Required=false)]
            public string NodeSelectType { get; set; }

            [NameInMap("NodeStartIndex")]
            [Validation(Required=false)]
            public int? NodeStartIndex { get; set; }

        }

    }

}
