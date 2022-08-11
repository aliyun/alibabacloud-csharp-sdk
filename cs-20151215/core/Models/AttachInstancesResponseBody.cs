// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<AttachInstancesResponseBodyList> List { get; set; }
        public class AttachInstancesResponseBodyList : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
