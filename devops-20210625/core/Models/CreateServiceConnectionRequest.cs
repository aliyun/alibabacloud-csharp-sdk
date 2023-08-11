// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateServiceConnectionRequest : TeaModel {
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("connectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        [NameInMap("connectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("serviceAuthId")]
        [Validation(Required=false)]
        public long? ServiceAuthId { get; set; }

    }

}
