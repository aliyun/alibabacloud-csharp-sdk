// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRealTimeDeliveryFieldResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnRealTimeDeliveryFieldResponseBodyContent Content { get; set; }
        public class DescribeDcdnRealTimeDeliveryFieldResponseBodyContent : TeaModel {
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<DescribeDcdnRealTimeDeliveryFieldResponseBodyContentFields> Fields { get; set; }
            public class DescribeDcdnRealTimeDeliveryFieldResponseBodyContentFields : TeaModel {
                public string Description { get; set; }
                public string FieldName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
