// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopIdsByVulNamesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DesktopItems")]
        [Validation(Required=false)]
        public List<DescribeDesktopIdsByVulNamesResponseBodyDesktopItems> DesktopItems { get; set; }
        public class DescribeDesktopIdsByVulNamesResponseBodyDesktopItems : TeaModel {
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

        }

    }

}
