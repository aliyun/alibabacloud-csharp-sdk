// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ContentPlanTopic : TeaModel {
        /// <summary>
        /// <para>The session ID for article generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conv_8a2b3c</para>
        /// </summary>
        [NameInMap("ArticleConversationId")]
        [Validation(Required=false)]
        public string ArticleConversationId { get; set; }

        /// <summary>
        /// <para>The ID of the generated article.</para>
        /// 
        /// <b>Example:</b>
        /// <para>art_9f2k3d</para>
        /// </summary>
        [NameInMap("ArticleId")]
        [Validation(Required=false)]
        public string ArticleId { get; set; }

        /// <summary>
        /// <para>The status of the associated article. Valid values: DRAFT, PUBLISHED, and PUBLISH_FAILED. This field is empty if no article is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISHED</para>
        /// </summary>
        [NameInMap("ArticleStatus")]
        [Validation(Required=false)]
        public string ArticleStatus { get; set; }

        /// <summary>
        /// <para>The delivery mode inherited from the plan. Valid values: SOCIAL, WEBSITE, and BOTH. Historical and unplanned manual entries default to SOCIAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BOTH</para>
        /// </summary>
        [NameInMap("DeliveryMode")]
        [Validation(Required=false)]
        public string DeliveryMode { get; set; }

        /// <summary>
        /// <para>The GEO diagnostic references.</para>
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
        /// <para>The reason for execution failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Article generation failed. Try again later</para>
        /// </summary>
        [NameInMap("FailReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        /// <summary>
        /// <para>Specifies whether user action is still required. Ignored or successful channels are not counted as pending tasks.</para>
        /// </summary>
        [NameInMap("NeedsAttention")]
        [Validation(Required=false)]
        public bool? NeedsAttention { get; set; }

        /// <summary>
        /// <para>The origin type. Valid values: PLAN for full-term plans and MANUAL for manual scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PLAN</para>
        /// </summary>
        [NameInMap("OriginType")]
        [Validation(Required=false)]
        public string OriginType { get; set; }

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
        /// <para>The workspace ID, which refers to the appWorkspaceId for GEO workspaces of the brand marketing type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d4e5f60718293a4b5c6d7e8f90a1b2c3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The topic rationale.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Users show high interest in the capabilities of AI website building products, making it a suitable entry point for brand awareness</para>
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
        /// <para>This topic is a duplicate of a published article and has been skipped</para>
        /// </summary>
        [NameInMap("SkipReason")]
        [Validation(Required=false)]
        public string SkipReason { get; set; }

        /// <summary>
        /// <para>The social media delivery status. Valid values: PENDING, RUNNING, FAILED, SUCCESS, and IGNORED. This field is empty if no record exists. Platform drafts are not considered successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PENDING</para>
        /// </summary>
        [NameInMap("SocialStatus")]
        [Validation(Required=false)]
        public string SocialStatus { get; set; }

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
        /// <para>Core capabilities of the Wanxiaozhi AI website builder</para>
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
        /// <para>The channel draft ID bound to the website delivery. This field is empty if no draft is created or no record exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>draft_example001</para>
        /// </summary>
        [NameInMap("WebsiteDraftId")]
        [Validation(Required=false)]
        public string WebsiteDraftId { get; set; }

        /// <summary>
        /// <para>The website target ID for the entry. If delivery exists, the bound website is used. If no article is generated, the plan configuration is inherited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20261126000000000001</para>
        /// </summary>
        [NameInMap("WebsiteId")]
        [Validation(Required=false)]
        public string WebsiteId { get; set; }

        /// <summary>
        /// <para>The website delivery status. Valid values: PENDING, RUNNING, UNKNOWN, FAILED, SUCCESS, and IGNORED. This field is empty if no record exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("WebsiteStatus")]
        [Validation(Required=false)]
        public string WebsiteStatus { get; set; }

        /// <summary>
        /// <para>The writing direction, which describes only the structure and perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Start with an overview of the product positioning, introduce the core capabilities in bullet points, and conclude with applicable scenarios</para>
        /// </summary>
        [NameInMap("WritingDirection")]
        [Validation(Required=false)]
        public string WritingDirection { get; set; }

    }

}
