// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserRealTimeDeliveryFieldResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContent Content { get; set; }
        public class DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContent : TeaModel {
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContentFields> Fields { get; set; }
            public class DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContentFields : TeaModel {
                public string Description { get; set; }
                public string FieldName { get; set; }
                public bool? Selected { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
