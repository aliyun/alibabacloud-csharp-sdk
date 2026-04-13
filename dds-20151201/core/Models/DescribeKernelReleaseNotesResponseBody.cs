// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKernelReleaseNotesResponseBody : TeaModel {
        [NameInMap("ReleaseNotes")]
        [Validation(Required=false)]
        public DescribeKernelReleaseNotesResponseBodyReleaseNotes ReleaseNotes { get; set; }
        public class DescribeKernelReleaseNotesResponseBodyReleaseNotes : TeaModel {
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public List<DescribeKernelReleaseNotesResponseBodyReleaseNotesReleaseNote> ReleaseNote { get; set; }
            public class DescribeKernelReleaseNotesResponseBodyReleaseNotesReleaseNote : TeaModel {
                [NameInMap("KernelVersion")]
                [Validation(Required=false)]
                public string KernelVersion { get; set; }

                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F01D4DDA-CB72-4083-B399-AF4642294FE6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
