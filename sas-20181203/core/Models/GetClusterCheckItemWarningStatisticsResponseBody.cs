// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterCheckItemWarningStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The baseline check statistics grouped by risk level (high, medium, and low).</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClusterCheckItemWarningStatisticsResponseBodyData Data { get; set; }
        public class GetClusterCheckItemWarningStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of high-risk check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HighWarningCount")]
            [Validation(Required=false)]
            public int? HighWarningCount { get; set; }

            /// <summary>
            /// <para>The number of low-risk check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LowWarningCount")]
            [Validation(Required=false)]
            public int? LowWarningCount { get; set; }

            /// <summary>
            /// <para>The number of medium-risk check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MediumWarningCount")]
            [Validation(Required=false)]
            public int? MediumWarningCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2B285A3-3493-5C5F-A224-4CCE4BFC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
