// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLifecyclePolicyLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution logs of the lifecycle policy.</para>
        /// </summary>
        [NameInMap("LifecyclePolicyLogs")]
        [Validation(Required=false)]
        public List<DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogs> LifecyclePolicyLogs { get; set; }
        public class DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogs : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time is displayed in UTC and is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-20T02:25:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The execution paths of the task.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// <para>The retrieval rules for file data.</para>
            /// </summary>
            [NameInMap("RetrieveRules")]
            [Validation(Required=false)]
            public List<DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsRetrieveRules> RetrieveRules { get; set; }
            public class DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsRetrieveRules : TeaModel {
                /// <summary>
                /// <para>The attribute of the rule. Valid value:</para>
                /// <list type="bullet">
                /// <item><description><c>RetrieveType</c>: The retrieval method.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RetrieveType</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The threshold of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>If <c>Attribute</c> is set to <c>RetrieveType</c>:</para>
                /// <list type="bullet">
                /// <item><description><para><c>AfterVisit</c>: Data is retrieved on a best-effort basis when accessed. This value is available only if <c>LifecyclePolicyType</c> is set to <c>Auto</c>.</para>
                /// </description></item>
                /// <item><description><para><c>All</c>: All data is retrieved. This value is available only if <c>LifecyclePolicyType</c> is set to <c>OnDemand</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PENDING</c>: The task is initializing.</para>
            /// </description></item>
            /// <item><description><para><c>RUNNING</c>: The task is running.</para>
            /// </description></item>
            /// <item><description><para><c>STOPPED</c>: The task is stopped.</para>
            /// </description></item>
            /// <item><description><para><c>FINISHED</c>: The task is complete.</para>
            /// </description></item>
            /// <item><description><para><c>FAILED</c>: The task failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage tier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>InfrequentAccess</c>: Infrequent Access (default).</para>
            /// </description></item>
            /// <item><description><para><c>Archive</c>: Archive Storage.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InfrequentAccess</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The task summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Total tasks: 100000, success tasks: 100000</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The transition rules for file data.</para>
            /// </summary>
            [NameInMap("TransitRules")]
            [Validation(Required=false)]
            public List<DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsTransitRules> TransitRules { get; set; }
            public class DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsTransitRules : TeaModel {
                /// <summary>
                /// <para>The attribute of the rule.</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description><c>Atime</c>: The last access time of a file.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Atime</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The rule threshold.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>If <c>Attribute</c> is set to <c>Atime</c>, this parameter specifies the number of days since a file was last accessed. The value must be an integer from 1 to 365.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC7C825C-5F65-4B56-BEF6-98C56C7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the request succeeded.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
