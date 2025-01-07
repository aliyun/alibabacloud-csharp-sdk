// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainSecureStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of domain names that trigger security alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AlarmCount")]
        [Validation(Required=false)]
        public int? AlarmCount { get; set; }

        /// <summary>
        /// <para>The number of the websites for which no certificates are installed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NoSslCount")]
        [Validation(Required=false)]
        public int? NoSslCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EE7B150-D67E-53FD-A52D-3E8E669A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of the domain names that have security risks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskCount")]
        [Validation(Required=false)]
        public int? RiskCount { get; set; }

        /// <summary>
        /// <para>The total number of domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72</para>
        /// </summary>
        [NameInMap("TotalDomainCount")]
        [Validation(Required=false)]
        public int? TotalDomainCount { get; set; }

        /// <summary>
        /// <para>The number of the domain names that have vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("VulCount")]
        [Validation(Required=false)]
        public int? VulCount { get; set; }

    }

}
