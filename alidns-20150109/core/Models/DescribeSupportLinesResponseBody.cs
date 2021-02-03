// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeSupportLinesResponseBody : TeaModel {
        [NameInMap("RecordLines")]
        [Validation(Required=false)]
        public DescribeSupportLinesResponseBodyRecordLines RecordLines { get; set; }
        public class DescribeSupportLinesResponseBodyRecordLines : TeaModel {
            [NameInMap("RecordLine")]
            [Validation(Required=false)]
            public List<DescribeSupportLinesResponseBodyRecordLinesRecordLine> RecordLine { get; set; }
            public class DescribeSupportLinesResponseBodyRecordLinesRecordLine : TeaModel {
                public string FatherCode { get; set; }
                public string LineDisplayName { get; set; }
                public string LineCode { get; set; }
                public string LineName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
