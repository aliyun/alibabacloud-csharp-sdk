// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateRdsExternalStoreRequest : TeaModel {
        [NameInMap("externalStoreName")]
        [Validation(Required=false)]
        public string ExternalStoreName { get; set; }

        [NameInMap("parameter")]
        [Validation(Required=false)]
        public UpdateRdsExternalStoreRequestParameter Parameter { get; set; }
        public class UpdateRdsExternalStoreRequestParameter : TeaModel {
            [NameInMap("db")]
            [Validation(Required=false)]
            public string Db { get; set; }

            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("instance-id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("vpc-id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
