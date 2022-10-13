// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableThemeLevelResponseBody : TeaModel {
        [NameInMap("Entity")]
        [Validation(Required=false)]
        public GetMetaTableThemeLevelResponseBodyEntity Entity { get; set; }
        public class GetMetaTableThemeLevelResponseBodyEntity : TeaModel {
            [NameInMap("Level")]
            [Validation(Required=false)]
            public List<GetMetaTableThemeLevelResponseBodyEntityLevel> Level { get; set; }
            public class GetMetaTableThemeLevelResponseBodyEntityLevel : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("LevelId")]
                [Validation(Required=false)]
                public long? LevelId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("Theme")]
            [Validation(Required=false)]
            public List<GetMetaTableThemeLevelResponseBodyEntityTheme> Theme { get; set; }
            public class GetMetaTableThemeLevelResponseBodyEntityTheme : TeaModel {
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("ThemeId")]
                [Validation(Required=false)]
                public long? ThemeId { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
