// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroupDiscoverRulesPreview : TeaModel {
        /// <summary>
        /// <para>The global association catalog version used for this preview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03ac8b5b92cb9c2675119d64c31d2520c069647aa9b88979df1bb115472c02b4</para>
        /// </summary>
        [NameInMap("catalogRevision")]
        [Validation(Required=false)]
        public string CatalogRevision { get; set; }

        /// <summary>
        /// <para>The number of entities returned on this page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The primary entities, associated sub-entities, and total count by entity type.</para>
        /// </summary>
        [NameInMap("entitySummaries")]
        [Validation(Required=false)]
        public List<ObserveGroupEntitySummary> EntitySummaries { get; set; }

        /// <summary>
        /// <para>The total count after filtering by entity role, type, and keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("filteredCount")]
        [Validation(Required=false)]
        public int? FilteredCount { get; set; }

        /// <summary>
        /// <para>The list of matched entities on this page.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<ObserveGroupInstance> Instances { get; set; }

        /// <summary>
        /// <para>The deduplicated count of primary entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("mainCount")]
        [Validation(Required=false)]
        public long? MainCount { get; set; }

        /// <summary>
        /// <para>The maximum number of entities returned on this page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The next page token, which is empty if there is no next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjEwLCJyZXF1ZXN0SGFzaCI6IjAzYWM4YjViOTJjYjljMjY3NTExOWQ2NGMzMWQyNTIwYzA2OTY0N2FhOWI4ODk3OWRmMWJiMTE1NDcyYzAyYjQifQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The deduplicated count of associated sub-entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("relatedCount")]
        [Validation(Required=false)]
        public long? RelatedCount { get; set; }

        /// <summary>
        /// <para>The primary entities, associated sub-entities, and total count by rule.</para>
        /// </summary>
        [NameInMap("ruleCounts")]
        [Validation(Required=false)]
        public List<ObserveGroupRuleCount> RuleCounts { get; set; }

        /// <summary>
        /// <para>The deduplicated total count of entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
