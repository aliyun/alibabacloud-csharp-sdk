// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeSelector : TeaModel {
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

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

    }

}
