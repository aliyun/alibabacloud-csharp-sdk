// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeCreditPackageAgentsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of agents.</para>
        /// </summary>
        [NameInMap("Agents")]
        [Validation(Required=false)]
        public List<DescribeCreditPackageAgentsResponseBodyAgents> Agents { get; set; }
        public class DescribeCreditPackageAgentsResponseBodyAgents : TeaModel {
            /// <summary>
            /// <para>The ID of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-abc</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para><b>The creation time of the instance.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-01 10:00:00</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para><b>The ID of the active credit package instance.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-inst-001</para>
            /// </summary>
            [NameInMap("CreditPackageId")]
            [Validation(Required=false)]
            public string CreditPackageId { get; set; }

            /// <summary>
            /// <para><b>The expiration time of the instance.</b></para>
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
            /// <para><b>The total credit.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("TotalCredit")]
            [Validation(Required=false)]
            public long? TotalCredit { get; set; }

            /// <summary>
            /// <para><b>The amount of credit used.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("UsedCredit")]
            [Validation(Required=false)]
            public long? UsedCredit { get; set; }

            /// <summary>
            /// <para><b>The alarm threshold, specified as a percentage. Valid values: 0 to 100.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("WarnPercent")]
            [Validation(Required=false)]
            public int? WarnPercent { get; set; }

        }

        /// <summary>
        /// <para>The number of results returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If this value is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID. Provide this ID when contacting support.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
