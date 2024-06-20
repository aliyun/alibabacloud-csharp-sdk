// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AntChainId")]
        [Validation(Required=false)]
        public string AntChainId { get; set; }

        [NameInMap("ContractId")]
        [Validation(Required=false)]
        public string ContractId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TransactionHash")]
        [Validation(Required=false)]
        public string TransactionHash { get; set; }

    }

}
