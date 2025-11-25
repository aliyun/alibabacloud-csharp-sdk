// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingRiskDomainAndIpCountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>EE258AC0-6EDD-5929-AB47-165E9B54****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("RiskDomainCount")]
        [Validation(Required=false)]
        public long? RiskDomainCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>47</para>
        /// </summary>
        [NameInMap("RiskIpCount")]
        [Validation(Required=false)]
        public long? RiskIpCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
