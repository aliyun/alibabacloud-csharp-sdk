// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class SearchStrategy : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("isDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        [NameInMap("mergeConfig")]
        [Validation(Required=false)]
        public SearchStrategyMergeConfig MergeConfig { get; set; }
        public class SearchStrategyMergeConfig : TeaModel {
            [NameInMap("docCount")]
            [Validation(Required=false)]
            public int? DocCount { get; set; }

            [NameInMap("rankName")]
            [Validation(Required=false)]
            public string RankName { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("searchConfigs")]
        [Validation(Required=false)]
        public List<SearchStrategySearchConfigs> SearchConfigs { get; set; }
        public class SearchStrategySearchConfigs : TeaModel {
            [NameInMap("firstRankName")]
            [Validation(Required=false)]
            public string FirstRankName { get; set; }

            [NameInMap("mergeProportion")]
            [Validation(Required=false)]
            public int? MergeProportion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>keyword: 关键字查询 vector: 向量查询</para>
            /// </summary>
            [NameInMap("queryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

            [NameInMap("secondRankName")]
            [Validation(Required=false)]
            public string SecondRankName { get; set; }

        }

    }

}
