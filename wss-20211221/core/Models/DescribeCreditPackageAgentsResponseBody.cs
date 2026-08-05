// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeCreditPackageAgentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The Agent list.</para>
        /// </summary>
        [NameInMap("Agents")]
        [Validation(Required=false)]
        public List<DescribeCreditPackageAgentsResponseBodyAgents> Agents { get; set; }
        public class DescribeCreditPackageAgentsResponseBodyAgents : TeaModel {
            /// <summary>
            /// <para>Agent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-abc</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para><b>The instance creation time.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-01 10:00:00</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para><b>The ID of the currently active credit package instance.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-inst-001</para>
            /// </summary>
            [NameInMap("CreditPackageId")]
            [Validation(Required=false)]
            public string CreditPackageId { get; set; }

            /// <summary>
            /// <para><b>The time when the instance expires.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-01 10:00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jvs-copilot.standard</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para><b>The total number of credits.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("TotalCredit")]
            [Validation(Required=false)]
            public long? TotalCredit { get; set; }

            /// <summary>
            /// <para><b>The amount of credits used.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("UsedCredit")]
            [Validation(Required=false)]
            public long? UsedCredit { get; set; }

            /// <summary>
            /// <para><b>The alert threshold percentage (0–100).</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("WarnPercent")]
            [Validation(Required=false)]
            public int? WarnPercent { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to an empty string for the first request. For subsequent requests, use the <c>nextToken</c> value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request trace ID, which is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
