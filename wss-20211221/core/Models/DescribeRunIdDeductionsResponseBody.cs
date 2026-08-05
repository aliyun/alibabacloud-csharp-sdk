// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeRunIdDeductionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The deduction details.</para>
        /// </summary>
        [NameInMap("Deductions")]
        [Validation(Required=false)]
        public List<DescribeRunIdDeductionsResponseBodyDeductions> Deductions { get; set; }
        public class DescribeRunIdDeductionsResponseBodyDeductions : TeaModel {
            /// <summary>
            /// <para>The agent type. Valid values: <c>CREDIT_PACKAGE</c>, <c>JVS_CLAW</c>, <c>OPEN_CLAW</c>, and <c>JVS_COPILOT</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenClaw</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The end time of the period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-31T03:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The group resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GROUP_CREDIT_PACKAGE、GROUP_BUSINESS_CREDIT_PACKAGE</para>
            /// </summary>
            [NameInMap("GroupResourceType")]
            [Validation(Required=false)]
            public string GroupResourceType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jvs-xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The credit or plan package ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crp-xxx</para>
            /// </summary>
            [NameInMap("PackageId")]
            [Validation(Required=false)]
            public string PackageId { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sunwyic.com</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreditPackage、BusinessCreditPackage</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The unique ID of the run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run-szwB1fYHCTocjGkFAIf6V8A</para>
            /// </summary>
            [NameInMap("RunId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-16T02:10:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The summary of the large language model call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>How is the weather today</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The usage duration. Unit: seconds. Do not use this field for AI scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>360000000</para>
            /// </summary>
            [NameInMap("UsedTime")]
            [Validation(Required=false)]
            public long? UsedTime { get; set; }

            /// <summary>
            /// <para>The credits used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.23</para>
            /// </summary>
            [NameInMap("UsedTimeDecimal")]
            [Validation(Required=false)]
            public string UsedTimeDecimal { get; set; }

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
        /// <para>The pagination token. Leave this parameter empty for the first request. For subsequent requests, use the <c>nextToken</c> value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>68BD3312-53D8-123E-BB32-1A9F25E07A03</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of core-hour package deduction details in the query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total usage duration. Unit: seconds. Do not use this field for AI scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("TotalUsedTime")]
        [Validation(Required=false)]
        public long? TotalUsedTime { get; set; }

        /// <summary>
        /// <para>The total credits used that match the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.23</para>
        /// </summary>
        [NameInMap("TotalUsedTimeDecimal")]
        [Validation(Required=false)]
        public string TotalUsedTimeDecimal { get; set; }

    }

}
