// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListClustersResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyResult> Result { get; set; }
        public class ListClustersResponseBodyResult : TeaModel {
            [NameInMap("configUpdateTime")]
            [Validation(Required=false)]
            public string ConfigUpdateTime { get; set; }

            [NameInMap("currentAdvanceConfigVersion")]
            [Validation(Required=false)]
            public string CurrentAdvanceConfigVersion { get; set; }

            /// <summary>
            /// 词典配置生效版本
            /// </summary>
            [NameInMap("currentOfflineDictConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOfflineDictConfigVersion { get; set; }

            [NameInMap("currentOnlineConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOnlineConfigVersion { get; set; }

            /// <summary>
            /// 查询配置生效版本
            /// </summary>
            [NameInMap("currentOnlineQueryConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOnlineQueryConfigVersion { get; set; }

            [NameInMap("dataNode")]
            [Validation(Required=false)]
            public ListClustersResponseBodyResultDataNode DataNode { get; set; }
            public class ListClustersResponseBodyResultDataNode : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                [NameInMap("partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

            }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("latestAdvanceConfigVersion")]
            [Validation(Required=false)]
            public string LatestAdvanceConfigVersion { get; set; }

            /// <summary>
            /// 词典配置最新版本
            /// </summary>
            [NameInMap("latestOfflineDictConfigVersion")]
            [Validation(Required=false)]
            public string LatestOfflineDictConfigVersion { get; set; }

            [NameInMap("latestOnlineConfigVersion")]
            [Validation(Required=false)]
            public string LatestOnlineConfigVersion { get; set; }

            /// <summary>
            /// 查询配置最新版本
            /// </summary>
            [NameInMap("latestOnlineQueryConfigVersion")]
            [Validation(Required=false)]
            public string LatestOnlineQueryConfigVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public ListClustersResponseBodyResultQueryNode QueryNode { get; set; }
            public class ListClustersResponseBodyResultQueryNode : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                [NameInMap("partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
