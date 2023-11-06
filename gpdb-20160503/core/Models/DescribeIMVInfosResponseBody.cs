// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeIMVInfosResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ImvInfos")]
        [Validation(Required=false)]
        public List<DescribeIMVInfosResponseBodyImvInfos> ImvInfos { get; set; }
        public class DescribeIMVInfosResponseBodyImvInfos : TeaModel {
            [NameInMap("Base")]
            [Validation(Required=false)]
            public string Base { get; set; }

            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public string DetailInfo { get; set; }

            [NameInMap("MV")]
            [Validation(Required=false)]
            public string MV { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
