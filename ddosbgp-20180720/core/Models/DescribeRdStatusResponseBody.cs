// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeRdStatusResponseBody : TeaModel {
        [NameInMap("CurrentUid")]
        [Validation(Required=false)]
        public string CurrentUid { get; set; }

        [NameInMap("CurrentUidType")]
        [Validation(Required=false)]
        public string CurrentUidType { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("LocalEnable")]
        [Validation(Required=false)]
        public bool? LocalEnable { get; set; }

        [NameInMap("MasterUid")]
        [Validation(Required=false)]
        public string MasterUid { get; set; }

        [NameInMap("RemoteEnable")]
        [Validation(Required=false)]
        public bool? RemoteEnable { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RootUid")]
        [Validation(Required=false)]
        public string RootUid { get; set; }

        [NameInMap("ServicePrincipalEnabled")]
        [Validation(Required=false)]
        public bool? ServicePrincipalEnabled { get; set; }

    }

}
