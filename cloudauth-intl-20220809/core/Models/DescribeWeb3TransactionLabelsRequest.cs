// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DescribeWeb3TransactionLabelsRequest : TeaModel {
        /// <summary>
        /// This is the short name of blockchain。
        /// [ ETH, MATIC, BNB ]
        /// </summary>
        [NameInMap("ChainShortName")]
        [Validation(Required=false)]
        public string ChainShortName { get; set; }

        /// <summary>
        /// A unique business ID for tracing purpose. For example，the sequence ID from the merchant\\"s business-related database.
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// The Transaction hash.
        /// </summary>
        [NameInMap("Transaction")]
        [Validation(Required=false)]
        public string Transaction { get; set; }

    }

}
