// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSLSRealTimeLogTypeResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnSLSRealTimeLogTypeResponseBodyContent Content { get; set; }
        public class DescribeDcdnSLSRealTimeLogTypeResponseBodyContent : TeaModel {
            [NameInMap("Business")]
            [Validation(Required=false)]
            public List<DescribeDcdnSLSRealTimeLogTypeResponseBodyContentBusiness> Business { get; set; }
            public class DescribeDcdnSLSRealTimeLogTypeResponseBodyContentBusiness : TeaModel {
                public string BusinessType { get; set; }
                public string Desc { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
