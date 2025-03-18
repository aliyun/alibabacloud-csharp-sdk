// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class DescribeScreenSummaryInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("AegisClientOfflineCount")]
        [Validation(Required=false)]
        public int? AegisClientOfflineCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127</para>
        /// </summary>
        [NameInMap("AegisClientOnlineCount")]
        [Validation(Required=false)]
        public int? AegisClientOnlineCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23AD0BD2-8771-5647-819E-XXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SecurityScore")]
        [Validation(Required=false)]
        public int? SecurityScore { get; set; }

    }

}
