// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ContentPlanGenerationTask : TeaModel {
        /// <summary>
        /// <para>The analysis conclusions, returned only after the analysis task succeeds.</para>
        /// </summary>
        [NameInMap("Analysis")]
        [Validation(Required=false)]
        public ContentPlanGenerationTaskAnalysis Analysis { get; set; }
        public class ContentPlanGenerationTaskAnalysis : TeaModel {
            /// <summary>
            /// <para>The analysis modules.</para>
            /// </summary>
            [NameInMap("Modules")]
            [Validation(Required=false)]
            public List<ContentPlanGenerationTaskAnalysisModules> Modules { get; set; }
            public class ContentPlanGenerationTaskAnalysisModules : TeaModel {
                /// <summary>
                /// <para>The module content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The current brand mention rate in the AI website builder category is lower than the industry average, and user perception is mostly focused on pricing</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The key questions.</para>
                /// </summary>
                [NameInMap("KeyQuestions")]
                [Validation(Required=false)]
                public List<string> KeyQuestions { get; set; }

                /// <summary>
                /// <para>The module title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Current status of brand awareness</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The reference article writing guidelines, which include only structure and perspective, excluding third-party facts.</para>
            /// </summary>
            [NameInMap("ReferenceWritingNotes")]
            [Validation(Required=false)]
            public List<string> ReferenceWritingNotes { get; set; }

            /// <summary>
            /// <para>The analysis summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Insufficient brand awareness is the current main shortcoming. It is recommended to prioritize adding content related to product capabilities</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

        }

        /// <summary>
        /// <para>The ID of the analysis task on which the scheduling task is based.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpt_1a2b3c4d5e6f708192a3b4c5d6e7f809</para>
        /// </summary>
        [NameInMap("AnalysisTaskId")]
        [Validation(Required=false)]
        public string AnalysisTaskId { get; set; }

        /// <summary>
        /// <para>The current configuration version of the workspace when the analysis is initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ConfigRevision")]
        [Validation(Required=false)]
        public long? ConfigRevision { get; set; }

        /// <summary>
        /// <para>The ID of the GEO diagnostic task used by the analysis node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f2e3d4c-5b6a-4798-8a9b-c0d1e2f3a4b5</para>
        /// </summary>
        [NameInMap("DiagnosisTaskId")]
        [Validation(Required=false)]
        public string DiagnosisTaskId { get; set; }

        /// <summary>
        /// <para>The error code for the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTENT_PLAN_AGENT_TIMEOUT</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message for the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Content plan generation timed out. Please try again later</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the content plan generated after the scheduling task succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_3f7a1c2e9b7d4a5f8c0e1d2b3a4c5d6e</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The task progress, ranging from 0 to 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The ID of the workspace, which refers to the GEO workspace for brand marketing, namely the appWorkspaceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d4e5f60718293a4b5c6d7e8f90a1b2c3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The workspace configuration version on which the diagnostic report is based. The analysis, scheduling, and article generation processes always read this version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ReportConfigRevision")]
        [Validation(Required=false)]
        public long? ReportConfigRevision { get; set; }

        /// <summary>
        /// <para>Indicates whether the diagnostic report is generated based on an outdated configuration. If the value is true, the frontend should prompt the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("StaleConfig")]
        [Validation(Required=false)]
        public bool? StaleConfig { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The submission time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800000</para>
        /// </summary>
        [NameInMap("SubmittedAt")]
        [Validation(Required=false)]
        public long? SubmittedAt { get; set; }

        /// <summary>
        /// <para>The ID of the generation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpt_9b7d4a5f8c0e1d2b3a4c5d6e3f7a1c2e</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task type. Valid values: ANALYSIS and SCHEDULE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCHEDULE</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The last update time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660900000</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
