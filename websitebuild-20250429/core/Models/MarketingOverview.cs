// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class MarketingOverview : TeaModel {
        /// <summary>
        /// <para>The number of articles distributed, aggregated by channel.</para>
        /// </summary>
        [NameInMap("ChannelDistribution")]
        [Validation(Required=false)]
        public List<MarketingChannelDistribution> ChannelDistribution { get; set; }

        /// <summary>
        /// <para>The number of items for which content generation failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ContentGenerationFailedCount")]
        [Validation(Required=false)]
        public long? ContentGenerationFailedCount { get; set; }

        /// <summary>
        /// <para>The number of content to-do items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ContentTodoCount")]
        [Validation(Required=false)]
        public long? ContentTodoCount { get; set; }

        /// <summary>
        /// <para>The number of distributed articles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("DistributedArticles")]
        [Validation(Required=false)]
        public long? DistributedArticles { get; set; }

        /// <summary>
        /// <para>The number of ended creation plans.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EndedPlanCount")]
        [Validation(Required=false)]
        public long? EndedPlanCount { get; set; }

        /// <summary>
        /// <para>The list of ended creation plans.</para>
        /// </summary>
        [NameInMap("EndedPlans")]
        [Validation(Required=false)]
        public List<MarketingEndedPlan> EndedPlans { get; set; }

        /// <summary>
        /// <para>The number of tasks for which articles have been generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("GeneratedArticleTasks")]
        [Validation(Required=false)]
        public long? GeneratedArticleTasks { get; set; }

        /// <summary>
        /// <para>The number of tasks for which images have been generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GeneratedImageTasks")]
        [Validation(Required=false)]
        public long? GeneratedImageTasks { get; set; }

        /// <summary>
        /// <para>The number of tasks for which videos have been generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GeneratedVideoTasks")]
        [Validation(Required=false)]
        public long? GeneratedVideoTasks { get; set; }

        /// <summary>
        /// <para>The daily content generation trend.</para>
        /// </summary>
        [NameInMap("GenerationTrend")]
        [Validation(Required=false)]
        public List<MarketingGenerationDay> GenerationTrend { get; set; }

        /// <summary>
        /// <para>The list of recently completed single diagnoses.</para>
        /// </summary>
        [NameInMap("LatestSingleDiagnoses")]
        [Validation(Required=false)]
        public List<MarketingDiagnosisSummary> LatestSingleDiagnoses { get; set; }

        /// <summary>
        /// <para>The number of items pending distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PendingDistributionCount")]
        [Validation(Required=false)]
        public long? PendingDistributionCount { get; set; }

        /// <summary>
        /// <para>The number of pending plan drafts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PendingPlanDrafts")]
        [Validation(Required=false)]
        public long? PendingPlanDrafts { get; set; }

        /// <summary>
        /// <para>The cumulative number of completed single GEO diagnostic nodes, which is not limited by the 30-day window and excludes project monitoring.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("SingleDiagnosisCount")]
        [Validation(Required=false)]
        public long? SingleDiagnosisCount { get; set; }

        /// <summary>
        /// <para>The IANA time zone used for the statistical window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para>The number of records that are missing an available generation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnknownGeneratedTimeCount")]
        [Validation(Required=false)]
        public long? UnknownGeneratedTimeCount { get; set; }

        /// <summary>
        /// <para>The number of records that are missing an available publish time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnknownPublishedTimeCount")]
        [Validation(Required=false)]
        public long? UnknownPublishedTimeCount { get; set; }

        /// <summary>
        /// <para>The list of unread diagnoses.</para>
        /// </summary>
        [NameInMap("UnreadDiagnoses")]
        [Validation(Required=false)]
        public List<MarketingDiagnosisSummary> UnreadDiagnoses { get; set; }

        /// <summary>
        /// <para>The number of unread diagnosis records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UnreadDiagnosisCount")]
        [Validation(Required=false)]
        public long? UnreadDiagnosisCount { get; set; }

        /// <summary>
        /// <para>The number of items for which publishing to the official website failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WebsitePublishFailedCount")]
        [Validation(Required=false)]
        public long? WebsitePublishFailedCount { get; set; }

        /// <summary>
        /// <para>The end time of the statistical window, as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1795737600000</para>
        /// </summary>
        [NameInMap("WindowEnd")]
        [Validation(Required=false)]
        public long? WindowEnd { get; set; }

        /// <summary>
        /// <para>The start time of the statistical window, as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1795651200000</para>
        /// </summary>
        [NameInMap("WindowStart")]
        [Validation(Required=false)]
        public long? WindowStart { get; set; }

    }

}
