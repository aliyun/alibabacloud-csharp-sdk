// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKernelReleaseNotesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the version release notes.</para>
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
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mongodb_20180619_0.4.9</para>
                /// </summary>
                [NameInMap("KernelVersion")]
                [Validation(Required=false)]
                public string KernelVersion { get; set; }

                /// <summary>
                /// <para>The release notes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test release note.</para>
                /// </summary>
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
