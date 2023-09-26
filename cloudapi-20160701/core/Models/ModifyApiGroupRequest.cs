// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class ModifyApiGroupRequest : TeaModel {
        [NameInMap("CompatibleFlags")]
        [Validation(Required=false)]
        public string CompatibleFlags { get; set; }

        [NameInMap("CustomTraceConfig")]
        [Validation(Required=false)]
        public string CustomTraceConfig { get; set; }

        [NameInMap("DefaultDomain")]
        [Validation(Required=false)]
        public string DefaultDomain { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("PassthroughHeaders")]
        [Validation(Required=false)]
        public string PassthroughHeaders { get; set; }

        [NameInMap("RpcPattern")]
        [Validation(Required=false)]
        public string RpcPattern { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("UserLogConfig")]
        [Validation(Required=false)]
        public string UserLogConfig { get; set; }

    }

}
