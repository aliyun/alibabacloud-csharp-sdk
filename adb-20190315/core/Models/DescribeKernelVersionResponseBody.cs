// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeKernelVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The minor versions to which you can update the current minor version of the cluster.</para>
        /// </summary>
        [NameInMap("AvailableKernelVersions")]
        [Validation(Required=false)]
        public List<DescribeKernelVersionResponseBodyAvailableKernelVersions> AvailableKernelVersions { get; set; }
        public class DescribeKernelVersionResponseBodyAvailableKernelVersions : TeaModel {
            /// <summary>
            /// <para>The maintenance expiration time of the version. The time follows the ISO 8601 standard in the yyyy-MM-DD HH:mm:ss format. The time is displayed in UTC. After the time arrives, the system no longer maintains the version. If any issues occur, update the minor version of the cluster to a later version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-01T10:36:30Z</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The minor version. Example: <b>3.1.9</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.1.9</para>
            /// </summary>
            [NameInMap("KernelVersion")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <para>The time when the minor version was released. The time follows the ISO 8601 standard in the yyyy-MM-DD HH:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-01T10:36:30Z</para>
            /// </summary>
            [NameInMap("ReleaseDate")]
            [Validation(Required=false)]
            public string ReleaseDate { get; set; }

        }

        /// <summary>
        /// <para>The maintenance expiration time of the version. The time follows the ISO 8601 standard in the yyyy-MM-DD HH:mm:ss format. The time is displayed in UTC. After the time arrives, the system no longer maintains the version. If any issues occur, update the minor version of the cluster to a later version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-01T10:36:30Z</para>
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// <para>The minor version of the cluster. Example: <b>3.1.8</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.1.8</para>
        /// </summary>
        [NameInMap("KernelVersion")]
        [Validation(Required=false)]
        public string KernelVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
