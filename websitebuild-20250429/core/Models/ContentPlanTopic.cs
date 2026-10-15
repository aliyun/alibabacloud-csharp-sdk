// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ContentPlanTopic : TeaModel {
        /// <summary>
        /// <para>The article generation session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conv_8a2b3c</para>
        /// </summary>
        [NameInMap("ArticleConversationId")]
        [Validation(Required=false)]
        public string ArticleConversationId { get; set; }

        /// <summary>
        /// <para>The generated article ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>art_9f2k3d</para>
        /// </summary>
        [NameInMap("ArticleId")]
        [Validation(Required=false)]
        public string ArticleId { get; set; }

        /// <summary>
        /// <para>The status of the associated article. Valid values: DRAFT, PUBLISHED, and PUBLISH_FAILED. This parameter is empty if the article is not generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISHED</para>
        /// </summary>
        [NameInMap("ArticleStatus")]
        [Validation(Required=false)]
        public string ArticleStatus { get; set; }

        /// <summary>
        /// <para>The GEO diagnostic item references.</para>
        /// </summary>
        [NameInMap("DiagnosisReferences")]
        [Validation(Required=false)]
        public List<string> DiagnosisReferences { get; set; }

        /// <summary>
        /// <para>The content direction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Introduction to product capabilities</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The reason for the execution failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Article generation failed. Try again later</para>
        /// </summary>
        [NameInMap("FailReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        /// <summary>
        /// <para>The content plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_3f7a1c2e9b7d4a5f8c0e1d2b3a4c5d6e</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The workspace ID. This refers to the GEO workspace for brand marketing, which is the appWorkspaceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d4e5f60718293a4b5c6d7e8f90a1b2c3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The rationale for topic selection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Users show high interest in AI website builder capabilities, making it a suitable entry point for brand awareness</para>
        /// </summary>
        [NameInMap("Rationale")]
        [Validation(Required=false)]
        public string Rationale { get; set; }

        /// <summary>
        /// <para>The recommended publishing channels.</para>
        /// </summary>
        [NameInMap("RecommendedChannels")]
        [Validation(Required=false)]
        public List<string> RecommendedChannels { get; set; }

        /// <summary>
        /// <para>The scheduled publish date in the yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-12</para>
        /// </summary>
        [NameInMap("ScheduledAt")]
        [Validation(Required=false)]
        public string ScheduledAt { get; set; }

        /// <summary>
        /// <para>The reason for skipping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This topic duplicates a published article and has been skipped</para>
        /// </summary>
        [NameInMap("SkipReason")]
        [Validation(Required=false)]
        public string SkipReason { get; set; }

        /// <summary>
        /// <para>The topic status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PENDING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The content title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analysis of the core capabilities of Wanxiaozhi AI website builder</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The topic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic_3f7a1c2e9b7d4a5f8c0e1d2b3a4c5d6e</para>
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public string TopicId { get; set; }

        /// <summary>
        /// <para>The writing direction, which only describes the structure and perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>First summarize the product positioning, then introduce the core capabilities point by point, and finally provide the applicable scenarios</para>
        /// </summary>
        [NameInMap("WritingDirection")]
        [Validation(Required=false)]
        public string WritingDirection { get; set; }

    }

}
