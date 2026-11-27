// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class MarketingContentTodo : TeaModel {
        /// <summary>
        /// <para>The article ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>article_example001</para>
        /// </summary>
        [NameInMap("ArticleId")]
        [Validation(Required=false)]
        public string ArticleId { get; set; }

        /// <summary>
        /// <para>The article creation session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conversation_example001</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The content creation plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_example001</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The GEO project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AW20261126000000000001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The reason for adding the entry to the to-do list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSITE_PUBLISH_FAILED</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The scheduled publication date of the entry in yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-26</para>
        /// </summary>
        [NameInMap("ScheduledAt")]
        [Validation(Required=false)]
        public string ScheduledAt { get; set; }

        /// <summary>
        /// <para>The distribution status of the social media channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PENDING</para>
        /// </summary>
        [NameInMap("SocialStatus")]
        [Validation(Required=false)]
        public string SocialStatus { get; set; }

        /// <summary>
        /// <para>The web page or content title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>About Example Technology</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The calendar topic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic_example001</para>
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public string TopicId { get; set; }

        /// <summary>
        /// <para>The distribution status of the official website channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("WebsiteStatus")]
        [Validation(Required=false)]
        public string WebsiteStatus { get; set; }

    }

}
