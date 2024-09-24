// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetImageScanNumInPeriodResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("ImageScanData")]
        [Validation(Required=false)]
        public GetImageScanNumInPeriodResponseBodyImageScanData ImageScanData { get; set; }
        public class GetImageScanNumInPeriodResponseBodyImageScanData : TeaModel {
            /// <summary>
            /// <para>The number of image scans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("ImageScanCount")]
            [Validation(Required=false)]
            public int? ImageScanCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
