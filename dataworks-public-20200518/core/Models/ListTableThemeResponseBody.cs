// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTableThemeResponseBody : TeaModel {
        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTableThemeResponseBodyData Data { get; set; }
        public class ListTableThemeResponseBodyData : TeaModel {
            /// <summary>
            /// The list of table levels.
            /// </summary>
            [NameInMap("ThemeList")]
            [Validation(Required=false)]
            public List<ListTableThemeResponseBodyDataThemeList> ThemeList { get; set; }
            public class ListTableThemeResponseBodyDataThemeList : TeaModel {
                /// <summary>
                /// The time when the table level was created.
                /// </summary>
                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                /// <summary>
                /// The creator of the table level.
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// The level of the table folder. Valid values: 1 and 2. The value 1 indicates the first level. The value 2 indicates the second level.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// The name of the table level.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ancestor node ID.
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// The DataWorks workspace ID.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The table theme ID.
                /// </summary>
                [NameInMap("ThemeId")]
                [Validation(Required=false)]
                public long? ThemeId { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
