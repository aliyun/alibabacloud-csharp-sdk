// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetUserPoolSyncJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A48EB1D-D645-5758-91AF-EDF8E36E257B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The synchronization task information.</para>
        /// </summary>
        [NameInMap("SynchronizationJob")]
        [Validation(Required=false)]
        public GetUserPoolSyncJobResponseBodySynchronizationJob SynchronizationJob { get; set; }
        public class GetUserPoolSyncJobResponseBodySynchronizationJob : TeaModel {
            /// <summary>
            /// <para>The end time of the synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-25T10:13:35Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The type of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The synchronization result statistics information.</para>
            /// </summary>
            [NameInMap("JobSummary")]
            [Validation(Required=false)]
            public GetUserPoolSyncJobResponseBodySynchronizationJobJobSummary JobSummary { get; set; }
            public class GetUserPoolSyncJobResponseBodySynchronizationJobJobSummary : TeaModel {
                /// <summary>
                /// <para>The statistics of created users in JSON format, including the following four fields: total (total count), success (success count), failed (failure count), and skipped (skipped count).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;total&quot;:24,&quot;success&quot;:24,&quot;failed&quot;:0,&quot;skipped&quot;:0}</para>
                /// </summary>
                [NameInMap("Created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                /// <summary>
                /// <para>The statistics of deleted users in JSON format, including the following four fields: total (total count), success (success count), failed (failure count), and skipped (skipped count).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;total&quot;:0,&quot;success&quot;:0,&quot;failed&quot;:0,&quot;skipped&quot;:0}</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public string Deleted { get; set; }

                /// <summary>
                /// <para>The statistics of unchanged users in JSON format, including the following four fields: total (total count), success (success count), failed (failure count), and skipped (skipped count).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;total&quot;:0,&quot;success&quot;:0,&quot;failed&quot;:0,&quot;skipped&quot;:0}</para>
                /// </summary>
                [NameInMap("Same")]
                [Validation(Required=false)]
                public string Same { get; set; }

                /// <summary>
                /// <para>The statistics of updated users in JSON format, including the following four fields: total (total count), success (success count), failed (failure count), and skipped (skipped count).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;total&quot;:0,&quot;success&quot;:0,&quot;failed&quot;:0,&quot;skipped&quot;:0}</para>
                /// </summary>
                [NameInMap("Updated")]
                [Validation(Required=false)]
                public string Updated { get; set; }

            }

            /// <summary>
            /// <para>The start time of the synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-25T10:13:35Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the synchronization task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Pending: The initial state.</para>
            /// </description></item>
            /// <item><description><para>Running: The task is running.</para>
            /// </description></item>
            /// <item><description><para>Failed: The task failed.</para>
            /// </description></item>
            /// <item><description><para>PartialSuccess: The task partially succeeded.</para>
            /// </description></item>
            /// <item><description><para>Success: The task succeeded.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>syncjob_8d713b14a63b4a559753492ab51c31f3</para>
            /// </summary>
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            /// <summary>
            /// <para>The trigger type of the synchronization task. Valid values: Manual (manually triggered). Only manual triggering is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

    }

}
