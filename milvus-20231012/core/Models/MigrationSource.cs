// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class MigrationSource : TeaModel {
        [NameInMap("authInfo")]
        [Validation(Required=false)]
        public MigrationSourceAuthInfo AuthInfo { get; set; }
        public class MigrationSourceAuthInfo : TeaModel {
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public MigrationSourceEndpoint Endpoint { get; set; }
        public class MigrationSourceEndpoint : TeaModel {
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

    }

}
