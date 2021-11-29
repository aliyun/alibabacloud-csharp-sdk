// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetReqAuthConfigRequest : TeaModel {
        [NameInMap("AuthRemoteDesc")]
        [Validation(Required=false)]
        public string AuthRemoteDesc { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("Key1")]
        [Validation(Required=false)]
        public string Key1 { get; set; }

        [NameInMap("Key2")]
        [Validation(Required=false)]
        public string Key2 { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("TimeOut")]
        [Validation(Required=false)]
        public string TimeOut { get; set; }

    }

}
