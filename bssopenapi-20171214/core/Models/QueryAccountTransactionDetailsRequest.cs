// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionDetailsRequest : TeaModel {
        /// <summary>
        /// The end of the creation time range to query.
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// The beginning of the creation time range to query.
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// This parameter is invalid.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for paging.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the order or bill.
        /// </summary>
        [NameInMap("RecordID")]
        [Validation(Required=false)]
        public string RecordID { get; set; }

        /// <summary>
        /// The transaction channel.
        /// </summary>
        [NameInMap("TransactionChannel")]
        [Validation(Required=false)]
        public string TransactionChannel { get; set; }

        /// <summary>
        /// The serial number of the transaction channel.
        /// </summary>
        [NameInMap("TransactionChannelSN")]
        [Validation(Required=false)]
        public string TransactionChannelSN { get; set; }

        /// <summary>
        /// The number of the transaction.
        /// </summary>
        [NameInMap("TransactionNumber")]
        [Validation(Required=false)]
        public string TransactionNumber { get; set; }

        /// <summary>
        /// The type of the transaction.
        /// </summary>
        [NameInMap("TransactionType")]
        [Validation(Required=false)]
        public string TransactionType { get; set; }

    }

}
