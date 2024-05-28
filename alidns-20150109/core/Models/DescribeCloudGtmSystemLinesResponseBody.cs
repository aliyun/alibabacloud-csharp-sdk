// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmSystemLinesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemLines")]
        [Validation(Required=false)]
        public DescribeCloudGtmSystemLinesResponseBodySystemLines SystemLines { get; set; }
        public class DescribeCloudGtmSystemLinesResponseBodySystemLines : TeaModel {
            [NameInMap("SystemLine")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmSystemLinesResponseBodySystemLinesSystemLine> SystemLine { get; set; }
            public class DescribeCloudGtmSystemLinesResponseBodySystemLinesSystemLine : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public bool? IsAvailable { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParentCode")]
                [Validation(Required=false)]
                public string ParentCode { get; set; }

            }

        }

        [NameInMap("SystemLinesTree")]
        [Validation(Required=false)]
        public string SystemLinesTree { get; set; }

    }

}
