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
            /// <para>The time when the task was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-20T02:25:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration and deletion rules for file data. You can configure up to one rule.</para>
            /// </summary>
            [NameInMap("DeleteRules")]
            [Validation(Required=false)]
            public List<DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsDeleteRules> DeleteRules { get; set; }
            public class DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsDeleteRules : TeaModel {
                /// <summary>
                /// <para>The attribute of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Atime: the last access time of the file.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Atime</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The threshold of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>If Attribute is set to Atime, the value indicates the number of days that a file has not been accessed. Valid values: 1 to 365.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

            /// <summary>
            /// <para>The execution paths specified for the retrieval task.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// <para>The data retrieval rules for files.</para>
            /// </summary>
            [NameInMap("RetrieveRules")]
            [Validation(Required=false)]
            public List<DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsRetrieveRules> RetrieveRules { get; set; }
            public class DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsRetrieveRules : TeaModel {
                /// <summary>
                /// <para>The attribute of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RetrieveType: the retrieval method.</description></item>
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
                /// <item><description>RetrieveType:<list type="bullet">
                /// <item><description>AfterVisit: Supported when LifecyclePolicyType is set to Auto. This value indicates best-effort recall on visit.</description></item>
                /// <item><description>All: Supported when LifecyclePolicyType is set to OnDemand. This value indicates that all data is retrieved.</description></item>
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
            /// <para>The status of the data retrieval task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: Creating</description></item>
            /// <item><description>RUNNING: Running</description></item>
            /// <item><description>STOPPED: Stopped</description></item>
            /// <item><description>FINISHED: Finished</description></item>
            /// <item><description>FAILED: Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tiered storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InfrequentAccess: IA storage class (default).</description></item>
            /// <item><description>Archive: Archive storage class.</description></item>
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
            /// <para>The data transition rules for files.</para>
            /// </summary>
            [NameInMap("TransitRules")]
            [Validation(Required=false)]
            public List<DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsTransitRules> TransitRules { get; set; }
            public class DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsTransitRules : TeaModel {
                /// <summary>
                /// <para>The attribute of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Atime: the last access time of the file.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Atime</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The threshold of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>If Attribute is set to Atime, the value indicates the number of days that a file has not been accessed. Valid values: 1 to 365.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC7C825C-5F65-4B56-BEF6-98C56C7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
