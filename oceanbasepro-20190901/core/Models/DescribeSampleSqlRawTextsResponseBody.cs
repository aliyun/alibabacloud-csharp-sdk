// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSampleSqlRawTextsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSampleSqlRawTextsResponseBodyData Data { get; set; }
        public class DescribeSampleSqlRawTextsResponseBodyData : TeaModel {
            [NameInMap("SqlText")]
            [Validation(Required=false)]
            public List<string> SqlText { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
