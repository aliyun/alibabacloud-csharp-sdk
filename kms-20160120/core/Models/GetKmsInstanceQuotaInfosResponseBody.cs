// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetKmsInstanceQuotaInfosResponseBody : TeaModel {
        [NameInMap("KmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

        [NameInMap("KmsInstanceQuotaInfos")]
        [Validation(Required=false)]
        public List<GetKmsInstanceQuotaInfosResponseBodyKmsInstanceQuotaInfos> KmsInstanceQuotaInfos { get; set; }
        public class GetKmsInstanceQuotaInfosResponseBodyKmsInstanceQuotaInfos : TeaModel {
            [NameInMap("ResourceQuota")]
            [Validation(Required=false)]
            public long? ResourceQuota { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("UsedQuantity")]
            [Validation(Required=false)]
            public long? UsedQuantity { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
