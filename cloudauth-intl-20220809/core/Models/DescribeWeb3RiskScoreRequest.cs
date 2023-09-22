// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DescribeWeb3RiskScoreRequest : TeaModel {
        /// <summary>
        /// This is the short name of blockchain。
        /// [ ETH, MATIC, BNB ]
        /// </summary>
        [NameInMap("ChainShortName")]
        [Validation(Required=false)]
        public string ChainShortName { get; set; }

        /// <summary>
        /// minimum: 1
        /// maximum: 100
        /// the maximum depth for risk analysis. For UTXO-based blockchains, default and maximum is enforced at 100.
        /// For account-based blockchains, default and maximum is enforced at 6
        /// </summary>
        [NameInMap("Depth")]
        [Validation(Required=false)]
        public int? Depth { get; set; }

        /// <summary>
        /// A unique business ID for tracing purpose. For example，the sequence ID from the merchant\"s business-related database.
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// For TRANSACTION objects, you need to provide the transaction hash。
        /// For ADDRESS objects, you need to provide the address or reference address hash。
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// The object of the analysis.
        /// [ TRANSACTION, ADDRESS ]
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}
