// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKernelReleaseNotesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReleaseNotes")]
        [Validation(Required=false)]
        public DescribeKernelReleaseNotesResponseBodyReleaseNotes ReleaseNotes { get; set; }
        public class DescribeKernelReleaseNotesResponseBodyReleaseNotes : TeaModel {
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public List<DescribeKernelReleaseNotesResponseBodyReleaseNotesReleaseNote> ReleaseNote { get; set; }
            public class DescribeKernelReleaseNotesResponseBodyReleaseNotesReleaseNote : TeaModel {
                public string ReleaseNote { get; set; }
                public string KernelVersion { get; set; }
            }
        };

    }

}
