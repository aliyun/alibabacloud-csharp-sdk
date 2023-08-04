// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds_data20220330.Models
{
    public class InsertListShrinkRequest : TeaModel {
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public string RecordsShrink { get; set; }

        [NameInMap("ResourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        [NameInMap("SecretArn")]
        [Validation(Required=false)]
        public string SecretArn { get; set; }

        [NameInMap("Table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
