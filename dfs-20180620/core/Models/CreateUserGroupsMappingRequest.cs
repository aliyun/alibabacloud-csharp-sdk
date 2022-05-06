// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class CreateUserGroupsMappingRequest : TeaModel {
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("GroupNames")]
        [Validation(Required=false)]
        public Dictionary<string, object> GroupNames { get; set; }

        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
