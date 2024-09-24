// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulDefendCountStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of defended vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RaspDefendedCount")]
        [Validation(Required=false)]
        public int? RaspDefendedCount { get; set; }

        /// <summary>
        /// <para>The number of supported vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RaspDefensibleCount")]
        [Validation(Required=false)]
        public int? RaspDefensibleCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F3B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
