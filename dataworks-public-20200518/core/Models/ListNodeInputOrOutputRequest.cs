// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodeInputOrOutputRequest : TeaModel {
        [NameInMap("IoType")]
        [Validation(Required=false)]
        public string IoType { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
