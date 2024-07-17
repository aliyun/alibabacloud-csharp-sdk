// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class CatalogConnection : TeaModel {
        [NameInMap("JdbcPassword")]
        [Validation(Required=false)]
        public string JdbcPassword { get; set; }

        [NameInMap("JdbcUri")]
        [Validation(Required=false)]
        public string JdbcUri { get; set; }

        [NameInMap("JdbcUserName")]
        [Validation(Required=false)]
        public string JdbcUserName { get; set; }

        [NameInMap("ThriftUri")]
        [Validation(Required=false)]
        public string ThriftUri { get; set; }

        [NameInMap("VpcConnectionId")]
        [Validation(Required=false)]
        public string VpcConnectionId { get; set; }

    }

}
