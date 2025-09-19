// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSecurityScanCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageSecurityScanCountResponseBodyData Data { get; set; }
        public class DescribeImageSecurityScanCountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of image baseline risks detected on the current asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ImageBaselineCount")]
            [Validation(Required=false)]
            public int? ImageBaselineCount { get; set; }

            /// <summary>
            /// <para>The number of image system vulnerabilities returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ImageCveVulCount")]
            [Validation(Required=false)]
            public int? ImageCveVulCount { get; set; }

            /// <summary>
            /// <para>The number of malicious image samples returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ImageMaliciousFileCount")]
            [Validation(Required=false)]
            public int? ImageMaliciousFileCount { get; set; }

            /// <summary>
            /// <para>The number of image application vulnerabilities returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ImageScaVulCount")]
            [Validation(Required=false)]
            public int? ImageScaVulCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C699E4E4-F2F4-58FC-A949-457FFE59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
