// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceVulStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EE7B150-D67E-53FD-A52D-3E8E669A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The vulnerability statistics information.</para>
        /// </summary>
        [NameInMap("VulStat")]
        [Validation(Required=false)]
        public DescribeInstanceVulStatisticsResponseBodyVulStat VulStat { get; set; }
        public class DescribeInstanceVulStatisticsResponseBodyVulStat : TeaModel {
            /// <summary>
            /// <para>The number of high-priority vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public string AsapCount { get; set; }

            /// <summary>
            /// <para>The number of medium-priority vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public string LaterCount { get; set; }

            /// <summary>
            /// <para>The number of low-priority vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public string NntfCount { get; set; }

        }

    }

}
