// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulMetaCountStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of application vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AppCount")]
        [Validation(Required=false)]
        public int? AppCount { get; set; }

        /// <summary>
        /// <para>The number of Linux software vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CveCount")]
        [Validation(Required=false)]
        public int? CveCount { get; set; }

        /// <summary>
        /// <para>The number of vulnerabilities that can be defended by the application protection feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RaspDefendCount")]
        [Validation(Required=false)]
        public int? RaspDefendCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>571B2642-BF51-5BDD-906B-D2340DB9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of Windows system vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SysCount")]
        [Validation(Required=false)]
        public int? SysCount { get; set; }

    }

}
