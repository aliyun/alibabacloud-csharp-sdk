// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ContentItem : TeaModel {
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public List<ContentItemExtInfo> ExtInfo { get; set; }
        public class ContentItemExtInfo : TeaModel {
            [NameInMap("alignment")]
            [Validation(Required=false)]
            public string Alignment { get; set; }

            [NameInMap("index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public List<long?> PageNum { get; set; }

            [NameInMap("pos")]
            [Validation(Required=false)]
            public List<ContentItemExtInfoPos> Pos { get; set; }
            public class ContentItemExtInfoPos : TeaModel {
                [NameInMap("x")]
                [Validation(Required=false)]
                public long? X { get; set; }

                [NameInMap("y")]
                [Validation(Required=false)]
                public long? Y { get; set; }

            }

            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("uniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

        }

        [NameInMap("score")]
        [Validation(Required=false)]
        public double? Score { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
