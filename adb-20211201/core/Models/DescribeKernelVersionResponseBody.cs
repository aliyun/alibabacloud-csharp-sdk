// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeKernelVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of target versions to which the current version can be upgraded.</para>
        /// </summary>
        [NameInMap("AvailableKernelVersions")]
        [Validation(Required=false)]
        public List<DescribeKernelVersionResponseBodyAvailableKernelVersions> AvailableKernelVersions { get; set; }
        public class DescribeKernelVersionResponseBodyAvailableKernelVersions : TeaModel {
            /// <summary>
            /// <para>The end-of-support date of the version. The time is in the yyyy-MM-DD HH:mm:ss format. After this date, the system no longer maintains this version. If any issues occur, upgrade to a later version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-17T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The kernel version number of the cluster. Example: <b>3.1.9</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.1.9</para>
            /// </summary>
            [NameInMap("KernelVersion")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <para>The release time of the kernel version. The time format is yyyy-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-17T16:00:00Z</para>
            /// </summary>
            [NameInMap("ReleaseDate")]
            [Validation(Required=false)]
            public string ReleaseDate { get; set; }

        }

        /// <summary>
        /// <para>The end-of-support date of the version. The time is in the yyyy-MM-DD HH:mm:ss format. After this date, the system no longer maintains this version. If any issues occur, upgrade to a later version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// <para>The kernel version number of the cluster. Example: <b>3.1.8</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.1.8</para>
        /// </summary>
        [NameInMap("KernelVersion")]
        [Validation(Required=false)]
        public string KernelVersion { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
