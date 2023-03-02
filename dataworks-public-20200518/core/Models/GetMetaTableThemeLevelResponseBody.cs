// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableThemeLevelResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Entity")]
        [Validation(Required=false)]
        public GetMetaTableThemeLevelResponseBodyEntity Entity { get; set; }
        public class GetMetaTableThemeLevelResponseBodyEntity : TeaModel {
            /// <summary>
            /// The information about the table level.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public List<GetMetaTableThemeLevelResponseBodyEntityLevel> Level { get; set; }
            public class GetMetaTableThemeLevelResponseBodyEntityLevel : TeaModel {
                /// <summary>
                /// The description of the table level.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the table level.
                /// </summary>
                [NameInMap("LevelId")]
                [Validation(Required=false)]
                public long? LevelId { get; set; }

                /// <summary>
                /// The name of the table level.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of the table level. Valid values:
                /// 
                /// *   1: indicates the logical level.
                /// *   2: indicates the physical level.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// The information about the table folder.
            /// </summary>
            [NameInMap("Theme")]
            [Validation(Required=false)]
            public List<GetMetaTableThemeLevelResponseBodyEntityTheme> Theme { get; set; }
            public class GetMetaTableThemeLevelResponseBodyEntityTheme : TeaModel {
                /// <summary>
                /// The level of the table folder. Valid values:
                /// 
                /// *   1: indicates a table folder of level 1.
                /// *   2: indicates a table folder of level 2.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// The name of the table folder.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the parent table folder.
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// The ID of the table folder.
                /// </summary>
                [NameInMap("ThemeId")]
                [Validation(Required=false)]
                public long? ThemeId { get; set; }

            }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request. You can troubleshoot errors based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
