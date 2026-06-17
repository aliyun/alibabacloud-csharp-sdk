// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of nodes that are in an abnormal state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExceptionCount")]
        [Validation(Required=false)]
        public long? ExceptionCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F98BAA59-5863-5B61-8FD4-C5E96813****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The number of unprotected assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("UnprotectedCount")]
        [Validation(Required=false)]
        public long? UnprotectedCount { get; set; }

        /// <summary>
        /// <para>The number of used quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UsedCount")]
        [Validation(Required=false)]
        public long? UsedCount { get; set; }

    }

}
