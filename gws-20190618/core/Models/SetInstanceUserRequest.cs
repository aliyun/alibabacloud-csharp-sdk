// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class SetInstanceUserRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("UserUid")]
        [Validation(Required=true)]
        public long UserUid { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=true)]
        public string UserName { get; set; }

    }

}
