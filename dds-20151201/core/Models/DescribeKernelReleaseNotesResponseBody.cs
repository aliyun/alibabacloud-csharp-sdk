// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKernelReleaseNotesResponseBody : TeaModel {
        /// <summary>
        /// The list of the version release notes.
        /// </summary>
        [NameInMap("ReleaseNotes")]
        [Validation(Required=false)]
        public DescribeKernelReleaseNotesResponseBodyReleaseNotes ReleaseNotes { get; set; }
        public class DescribeKernelReleaseNotesResponseBodyReleaseNotes : TeaModel {
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public List<DescribeKernelReleaseNotesResponseBodyReleaseNotesReleaseNote> ReleaseNote { get; set; }
            public class DescribeKernelReleaseNotesResponseBodyReleaseNotesReleaseNote : TeaModel {
                /// <summary>
                /// The version number.
                /// </summary>
                [NameInMap("KernelVersion")]
                [Validation(Required=false)]
                public string KernelVersion { get; set; }

                /// <summary>
                /// The release notes.
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
