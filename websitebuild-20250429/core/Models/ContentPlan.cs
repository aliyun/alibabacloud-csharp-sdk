// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ContentPlan : TeaModel {
        /// <summary>
        /// <para>The additional user comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Highlight the differentiated capabilities of the product and avoid exaggerated claims</para>
        /// </summary>
        [NameInMap("AdditionalRequirements")]
        [Validation(Required=false)]
        public string AdditionalRequirements { get; set; }

        /// <summary>
        /// <para>The ID of the analysis task used for scheduling.</para>
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
        /// <para>The completion time of the GEO diagnosis, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800000</para>
        /// </summary>
        [NameInMap("DiagnosisCompletedAt")]
        [Validation(Required=false)]
        public long? DiagnosisCompletedAt { get; set; }

        /// <summary>
        /// <para>The ID of the GEO diagnostic node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f2e3d4c-5b6a-4798-8a9b-c0d1e2f3a4b5</para>
        /// </summary>
        [NameInMap("DiagnosisTaskId")]
        [Validation(Required=false)]
        public string DiagnosisTaskId { get; set; }

        /// <summary>
        /// <para>The type of the GEO diagnosis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GEO_BRAND</para>
        /// </summary>
        [NameInMap("DiagnosisType")]
        [Validation(Required=false)]
        public string DiagnosisType { get; set; }

        /// <summary>
        /// <para>The end date of the plan in the yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-18</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The ID of the generation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpt_9b7d4a5f8c0e1d2b3a4c5d6e3f7a1c2e</para>
        /// </summary>
        [NameInMap("GenerationTaskId")]
        [Validation(Required=false)]
        public string GenerationTaskId { get; set; }

        /// <summary>
        /// <para>The ID of the content plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_3f7a1c2e9b7d4a5f8c0e1d2b3a4c5d6e</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace, which is the GEO workspace for brand marketing and corresponds to the appWorkspaceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d4e5f60718293a4b5c6d7e8f90a1b2c3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The number of scheduled articles, which equals the number of matched generation days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PublishFrequency")]
        [Validation(Required=false)]
        public int? PublishFrequency { get; set; }

        /// <summary>
        /// <para>The workspace configuration version used for the diagnostic report, which is strictly read during article generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ReportConfigRevision")]
        [Validation(Required=false)]
        public long? ReportConfigRevision { get; set; }

        /// <summary>
        /// <para>The start date of the plan in the yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-12</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The status of the plan. Valid values: ACTIVE, SUPERSEDED, COMPLETED, and FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The summary of the overall strategy for the plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This week focuses on two themes: brand awareness and product capabilities, with a total of three articles</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The ID of the new plan that supersedes the current plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_7a1c2e9b7d4a5f8c0e1d2b3a4c5d6e3f</para>
        /// </summary>
        [NameInMap("SupersededBy")]
        [Validation(Required=false)]
        public string SupersededBy { get; set; }

        /// <summary>
        /// <para>The IANA time zone used for scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The weekly generation days, where ISO weekday 1 represents Monday and 7 represents Sunday.</para>
        /// </summary>
        [NameInMap("Weekdays")]
        [Validation(Required=false)]
        public List<int?> Weekdays { get; set; }

    }

}
