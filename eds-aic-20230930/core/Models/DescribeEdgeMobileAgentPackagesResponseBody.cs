// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeEdgeMobileAgentPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The actual number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that no more data exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of packages.</para>
        /// </summary>
        [NameInMap("Packages")]
        [Validation(Required=false)]
        public List<DescribeEdgeMobileAgentPackagesResponseBodyPackages> Packages { get; set; }
        public class DescribeEdgeMobileAgentPackagesResponseBodyPackages : TeaModel {
            /// <summary>
            /// <para>The device type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BOX</para>
            /// </summary>
            [NameInMap("DeviceClass")]
            [Validation(Required=false)]
            public string DeviceClass { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-05 10:04:07</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The list of license keys.</para>
            /// </summary>
            [NameInMap("LicenseKeys")]
            [Validation(Required=false)]
            public List<string> LicenseKeys { get; set; }

            /// <summary>
            /// <para>The package ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmag-0c1g77wjljl9hc****</para>
            /// </summary>
            [NameInMap("PackageId")]
            [Validation(Required=false)]
            public string PackageId { get; set; }

            /// <summary>
            /// <para>The package specification. Currently, only hardware is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hardware</para>
            /// </summary>
            [NameInMap("PackageSpec")]
            [Validation(Required=false)]
            public string PackageSpec { get; set; }

            /// <summary>
            /// <para>The package status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C5CEF0A-D6E1-58D3-8750-67DB4F82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
