// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class ImportNumberRequest : TeaModel {
        [NameInMap("Customers")]
        [Validation(Required=false)]
        public List<ImportNumberRequestCustomers> Customers { get; set; }
        public class ImportNumberRequestCustomers : TeaModel {
            [NameInMap("ClientUrl")]
            [Validation(Required=false)]
            public string ClientUrl { get; set; }

            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            [NameInMap("NumberMD5")]
            [Validation(Required=false)]
            public string NumberMD5 { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("FailReturn")]
        [Validation(Required=false)]
        public long? FailReturn { get; set; }

        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
