// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class MarketingOverview : TeaModel {
        [NameInMap("ChannelDistribution")]
        [Validation(Required=false)]
        public List<MarketingChannelDistribution> ChannelDistribution { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ContentGenerationFailedCount")]
        [Validation(Required=false)]
        public long? ContentGenerationFailedCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ContentTodoCount")]
        [Validation(Required=false)]
        public long? ContentTodoCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("DistributedArticles")]
        [Validation(Required=false)]
        public long? DistributedArticles { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EndedPlanCount")]
        [Validation(Required=false)]
        public long? EndedPlanCount { get; set; }

        [NameInMap("EndedPlans")]
        [Validation(Required=false)]
        public List<MarketingEndedPlan> EndedPlans { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("GeneratedArticleTasks")]
        [Validation(Required=false)]
        public long? GeneratedArticleTasks { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GeneratedImageTasks")]
        [Validation(Required=false)]
        public long? GeneratedImageTasks { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GeneratedVideoTasks")]
        [Validation(Required=false)]
        public long? GeneratedVideoTasks { get; set; }

        [NameInMap("GenerationTrend")]
        [Validation(Required=false)]
        public List<MarketingGenerationDay> GenerationTrend { get; set; }

        [NameInMap("LatestSingleDiagnoses")]
        [Validation(Required=false)]
        public List<MarketingDiagnosisSummary> LatestSingleDiagnoses { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PendingDistributionCount")]
        [Validation(Required=false)]
        public long? PendingDistributionCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PendingPlanDrafts")]
        [Validation(Required=false)]
        public long? PendingPlanDrafts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("SingleDiagnosisCount")]
        [Validation(Required=false)]
        public long? SingleDiagnosisCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnknownGeneratedTimeCount")]
        [Validation(Required=false)]
        public long? UnknownGeneratedTimeCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnknownPublishedTimeCount")]
        [Validation(Required=false)]
        public long? UnknownPublishedTimeCount { get; set; }

        [NameInMap("UnreadDiagnoses")]
        [Validation(Required=false)]
        public List<MarketingDiagnosisSummary> UnreadDiagnoses { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UnreadDiagnosisCount")]
        [Validation(Required=false)]
        public long? UnreadDiagnosisCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WebsitePublishFailedCount")]
        [Validation(Required=false)]
        public long? WebsitePublishFailedCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1795737600000</para>
        /// </summary>
        [NameInMap("WindowEnd")]
        [Validation(Required=false)]
        public long? WindowEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1795651200000</para>
        /// </summary>
        [NameInMap("WindowStart")]
        [Validation(Required=false)]
        public long? WindowStart { get; set; }

    }

}
