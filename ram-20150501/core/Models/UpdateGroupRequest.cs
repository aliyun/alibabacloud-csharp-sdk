// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UpdateGroupRequest : TeaModel {
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("NewComments")]
        [Validation(Required=false)]
        public string NewComments { get; set; }

        [NameInMap("NewGroupName")]
        [Validation(Required=false)]
        public string NewGroupName { get; set; }

    }

}
