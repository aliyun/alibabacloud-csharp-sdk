// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class QueryChangeInfoRequest : TeaModel {
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSign")]
        [Validation(Required=false)]
        public string AuthSign { get; set; }

        [NameInMap("Az")]
        [Validation(Required=false)]
        public List<string> Az { get; set; }

        [NameInMap("BgVid")]
        [Validation(Required=false)]
        public string BgVid { get; set; }

        [NameInMap("BuId")]
        [Validation(Required=false)]
        public string BuId { get; set; }

        [NameInMap("ChangeSystem")]
        [Validation(Required=false)]
        public string ChangeSystem { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("LevelTree")]
        [Validation(Required=false)]
        public QueryChangeInfoRequestLevelTree LevelTree { get; set; }
        public class QueryChangeInfoRequestLevelTree : TeaModel {
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("TreeData")]
            [Validation(Required=false)]
            public List<QueryChangeInfoRequestLevelTreeTreeData> TreeData { get; set; }
            public class QueryChangeInfoRequestLevelTreeTreeData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<object> Data { get; set; }

                [NameInMap("DataSubType")]
                [Validation(Required=false)]
                public string DataSubType { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<string> Value { get; set; }

            }

        }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public List<string> Product { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public List<string> Region { get; set; }

        [NameInMap("ReqTimestamp")]
        [Validation(Required=false)]
        public long? ReqTimestamp { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SourceOrderId")]
        [Validation(Required=false)]
        public string SourceOrderId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
