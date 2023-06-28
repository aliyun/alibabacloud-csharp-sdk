// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class GetCredentialPoolStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCredentialPoolStatisticsResponseBodyData Data { get; set; }
        public class GetCredentialPoolStatisticsResponseBodyData : TeaModel {
            [NameInMap("CardActiveNum")]
            [Validation(Required=false)]
            public long? CardActiveNum { get; set; }

            [NameInMap("CardTotalNum")]
            [Validation(Required=false)]
            public long? CardTotalNum { get; set; }

            [NameInMap("CredentialInstanceId")]
            [Validation(Required=false)]
            public string CredentialInstanceId { get; set; }

            [NameInMap("CredentialNO")]
            [Validation(Required=false)]
            public string CredentialNO { get; set; }

            [NameInMap("CredentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            [NameInMap("EffectiveAvailableFlow")]
            [Validation(Required=false)]
            public string EffectiveAvailableFlow { get; set; }

            [NameInMap("EffectiveTotalFlow")]
            [Validation(Required=false)]
            public string EffectiveTotalFlow { get; set; }

            [NameInMap("MonthExceedFee")]
            [Validation(Required=false)]
            public long? MonthExceedFee { get; set; }

            [NameInMap("MonthFeatureFee")]
            [Validation(Required=false)]
            public long? MonthFeatureFee { get; set; }

            [NameInMap("MonthUsedAmount")]
            [Validation(Required=false)]
            public long? MonthUsedAmount { get; set; }

            [NameInMap("PoolAvaiable")]
            [Validation(Required=false)]
            public string PoolAvaiable { get; set; }

            [NameInMap("PoolGrandTotal")]
            [Validation(Required=false)]
            public string PoolGrandTotal { get; set; }

            [NameInMap("PoolGrandTotalUsed")]
            [Validation(Required=false)]
            public string PoolGrandTotalUsed { get; set; }

            [NameInMap("PoolOutUsed")]
            [Validation(Required=false)]
            public string PoolOutUsed { get; set; }

            [NameInMap("PoolUsed")]
            [Validation(Required=false)]
            public string PoolUsed { get; set; }

            [NameInMap("SmsUsed")]
            [Validation(Required=false)]
            public long? SmsUsed { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
