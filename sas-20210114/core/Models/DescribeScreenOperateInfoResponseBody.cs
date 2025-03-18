// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class DescribeScreenOperateInfoResponseBody : TeaModel {
        [NameInMap("DateArray")]
        [Validation(Required=false)]
        public List<string> DateArray { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HealthCheckDealedCount")]
        [Validation(Required=false)]
        public int? HealthCheckDealedCount { get; set; }

        [NameInMap("HealthCheckValueArray")]
        [Validation(Required=false)]
        public List<string> HealthCheckValueArray { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23AD0BD2-8771-5647-819E-6xxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SecurityEventDealedCount")]
        [Validation(Required=false)]
        public int? SecurityEventDealedCount { get; set; }

        [NameInMap("SuspEventValueArray")]
        [Validation(Required=false)]
        public List<string> SuspEventValueArray { get; set; }

        [NameInMap("VulValueArray")]
        [Validation(Required=false)]
        public List<string> VulValueArray { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VulnerabilityDealedCount")]
        [Validation(Required=false)]
        public int? VulnerabilityDealedCount { get; set; }

    }

}
