// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLifecyclePolicyLogsResponseBody : TeaModel {
        [NameInMap("LifecyclePolicyLogs")]
        [Validation(Required=false)]
        public List<DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogs> LifecyclePolicyLogs { get; set; }
        public class DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-10-20T02:25:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            [NameInMap("RetrieveRules")]
            [Validation(Required=false)]
            public List<DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsRetrieveRules> RetrieveRules { get; set; }
            public class DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsRetrieveRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RetrieveType</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InfrequentAccess</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("TransitRules")]
            [Validation(Required=false)]
            public List<DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsTransitRules> TransitRules { get; set; }
            public class DescribeLifecyclePolicyLogsResponseBodyLifecyclePolicyLogsTransitRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Atime</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BC7C825C-5F65-4B56-BEF6-98C56C7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>36</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
