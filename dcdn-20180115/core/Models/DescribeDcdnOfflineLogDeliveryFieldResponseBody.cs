// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnOfflineLogDeliveryFieldResponseBody : TeaModel {
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<DescribeDcdnOfflineLogDeliveryFieldResponseBodyFields> Fields { get; set; }
        public class DescribeDcdnOfflineLogDeliveryFieldResponseBodyFields : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
