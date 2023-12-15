// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest : TeaModel {
        [NameInMap("AntChainId")]
        [Validation(Required=false)]
        public string AntChainId { get; set; }

        [NameInMap("ContractId")]
        [Validation(Required=false)]
        public string ContractId { get; set; }

        [NameInMap("TransactionHash")]
        [Validation(Required=false)]
        public string TransactionHash { get; set; }

    }

}
