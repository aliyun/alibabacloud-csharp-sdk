// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class DescribeScreenCloudHcRiskResponseBody : TeaModel {
        [NameInMap("CloudHcRiskItems")]
        [Validation(Required=false)]
        public List<DescribeScreenCloudHcRiskResponseBodyCloudHcRiskItems> CloudHcRiskItems { get; set; }
        public class DescribeScreenCloudHcRiskResponseBodyCloudHcRiskItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AffectCount")]
            [Validation(Required=false)]
            public int? AffectCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS-PublicReadOpenManifestFileWithoutEncryption</para>
            /// </summary>
            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C8487EF-50C2-54BB-8634-10F8C35D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
