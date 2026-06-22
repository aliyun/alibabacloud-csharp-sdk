// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageScanAuthCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization details of image security scanning.</para>
        /// </summary>
        [NameInMap("ImageScan")]
        [Validation(Required=false)]
        public DescribeImageScanAuthCountResponseBodyImageScan ImageScan { get; set; }
        public class DescribeImageScanAuthCountResponseBodyImageScan : TeaModel {
            /// <summary>
            /// <para>The total number of authorization quotas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15340</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public long? ImageScanCapacity { get; set; }

            /// <summary>
            /// <para>The instance ID of the purchased Security Center instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-qdl123412****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of used authorization quotas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5489</para>
            /// </summary>
            [NameInMap("ScanCount")]
            [Validation(Required=false)]
            public long? ScanCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The China Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>892NYH839-0EDC-4CD0-A2EF-5BD294656C99</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
