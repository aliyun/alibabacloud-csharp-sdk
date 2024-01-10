// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dg20190327.Models
{
    public class ModifyDatabaseRequest : TeaModel {
        [NameInMap("DbDescription")]
        [Validation(Required=false)]
        public string DbDescription { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DbPassword")]
        [Validation(Required=false)]
        public string DbPassword { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("DbUserName")]
        [Validation(Required=false)]
        public string DbUserName { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

    }

}
