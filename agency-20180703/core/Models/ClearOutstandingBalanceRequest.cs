/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class ClearOutstandingBalanceRequest : TeaModel {
        [NameInMap("AliyunPk")]
        [Validation(Required=false)]
        public long? AliyunPk { get; set; }

        [NameInMap("DebtQuota")]
        [Validation(Required=false)]
        public string DebtQuota { get; set; }

        [NameInMap("EndUserPk")]
        [Validation(Required=false)]
        public long? EndUserPk { get; set; }

    }

}
