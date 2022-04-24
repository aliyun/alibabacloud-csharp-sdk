// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionsRequest : TeaModel {
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RecordID")]
        [Validation(Required=false)]
        public string RecordID { get; set; }

        [NameInMap("TransactionChannel")]
        [Validation(Required=false)]
        public string TransactionChannel { get; set; }

        [NameInMap("TransactionChannelSN")]
        [Validation(Required=false)]
        public string TransactionChannelSN { get; set; }

        [NameInMap("TransactionFlow")]
        [Validation(Required=false)]
        public string TransactionFlow { get; set; }

        [NameInMap("TransactionNumber")]
        [Validation(Required=false)]
        public string TransactionNumber { get; set; }

        [NameInMap("TransactionType")]
        [Validation(Required=false)]
        public string TransactionType { get; set; }

    }

}
