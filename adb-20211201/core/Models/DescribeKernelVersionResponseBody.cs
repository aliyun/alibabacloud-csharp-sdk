// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeKernelVersionResponseBody : TeaModel {
        [NameInMap("AvailableKernelVersions")]
        [Validation(Required=false)]
        public List<DescribeKernelVersionResponseBodyAvailableKernelVersions> AvailableKernelVersions { get; set; }
        public class DescribeKernelVersionResponseBodyAvailableKernelVersions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-17T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3.1.9</para>
            /// </summary>
            [NameInMap("KernelVersion")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-17T16:00:00Z</para>
            /// </summary>
            [NameInMap("ReleaseDate")]
            [Validation(Required=false)]
            public string ReleaseDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-01-12T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3.1.8</para>
        /// </summary>
        [NameInMap("KernelVersion")]
        [Validation(Required=false)]
        public string KernelVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
