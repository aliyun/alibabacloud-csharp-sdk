/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckResultRequest : TeaModel {
        [NameInMap("ExtraImageControlList")]
        [Validation(Required=false)]
        public string ExtraImageControlList { get; set; }

        [NameInMap("IsReturnImage")]
        [Validation(Required=false)]
        public string IsReturnImage { get; set; }

        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        [NameInMap("ReturnFiveCategorySpoofResult")]
        [Validation(Required=false)]
        public string ReturnFiveCategorySpoofResult { get; set; }

        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
