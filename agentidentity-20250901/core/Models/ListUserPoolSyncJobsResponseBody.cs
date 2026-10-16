// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListUserPoolSyncJobsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SynchronizationJobs")]
        [Validation(Required=false)]
        public List<ListUserPoolSyncJobsResponseBodySynchronizationJobs> SynchronizationJobs { get; set; }
        public class ListUserPoolSyncJobsResponseBodySynchronizationJobs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-15T01:50:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            [NameInMap("JobSummary")]
            [Validation(Required=false)]
            public ListUserPoolSyncJobsResponseBodySynchronizationJobsJobSummary JobSummary { get; set; }
            public class ListUserPoolSyncJobsResponseBodySynchronizationJobsJobSummary : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;total&quot;:0,&quot;success&quot;:0,&quot;failed&quot;:0,&quot;skipped&quot;:0}</para>
                /// </summary>
                [NameInMap("Created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;total&quot;:0,&quot;success&quot;:0,&quot;failed&quot;:0,&quot;skipped&quot;:0}</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public string Deleted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;total&quot;:0,&quot;success&quot;:0,&quot;failed&quot;:0,&quot;skipped&quot;:0}</para>
                /// </summary>
                [NameInMap("Same")]
                [Validation(Required=false)]
                public string Same { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;total&quot;:0,&quot;success&quot;:0,&quot;failed&quot;:0,&quot;skipped&quot;:0}</para>
                /// </summary>
                [NameInMap("Updated")]
                [Validation(Required=false)]
                public string Updated { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-13T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>syncjob_8d713b14a63b4a559753492ab51c31f3</para>
            /// </summary>
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
