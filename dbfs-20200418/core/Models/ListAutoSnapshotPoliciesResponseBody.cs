// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListAutoSnapshotPoliciesResponseBody : TeaModel {
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotPolicies")]
        [Validation(Required=false)]
        public List<ListAutoSnapshotPoliciesResponseBodySnapshotPolicies> SnapshotPolicies { get; set; }
        public class ListAutoSnapshotPoliciesResponseBodySnapshotPolicies : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>13523459********</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AppliedDbfsNumber")]
            [Validation(Required=false)]
            public int? AppliedDbfsNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1670998784000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1670998784000</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sp-z5siir3iq3m**********</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policyTest</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RepeatWeekdays")]
            [Validation(Required=false)]
            public List<string> RepeatWeekdays { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RetentionDays")]
            [Validation(Required=false)]
            public int? RetentionDays { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

            [NameInMap("TimePoints")]
            [Validation(Required=false)]
            public List<string> TimePoints { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
