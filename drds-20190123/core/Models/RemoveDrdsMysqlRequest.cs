// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class RemoveDrdsMysqlRequest : TeaModel {
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        [NameInMap("RoDbInstanceId")]
        [Validation(Required=false)]
        public string RoDbInstanceId { get; set; }

    }

}
