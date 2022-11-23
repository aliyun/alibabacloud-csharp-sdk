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
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                [NameInMap("LineDisplayName")]
                [Validation(Required=false)]
                public string LineDisplayName { get; set; }

                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
