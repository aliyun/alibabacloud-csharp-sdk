// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTableLevelResponseBody : TeaModel {
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

        /// <summary>
        /// The information about the table levels.
        /// </summary>
        [NameInMap("TableLevelInfo")]
        [Validation(Required=false)]
        public ListTableLevelResponseBodyTableLevelInfo TableLevelInfo { get; set; }
        public class ListTableLevelResponseBodyTableLevelInfo : TeaModel {
            /// <summary>
            /// The list of table levels.
            /// </summary>
            [NameInMap("LevelList")]
            [Validation(Required=false)]
            public List<ListTableLevelResponseBodyTableLevelInfoLevelList> LevelList { get; set; }
            public class ListTableLevelResponseBodyTableLevelInfoLevelList : TeaModel {
                /// <summary>
                /// The description of the table level.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The table level ID.
                /// </summary>
                [NameInMap("LevelId")]
                [Validation(Required=false)]
                public long? LevelId { get; set; }

                /// <summary>
                /// The table level type. Valid values: 1 and 2. The value 1 indicates the logical level. The value 2 indicates the physical level.
                /// </summary>
                [NameInMap("LevelType")]
                [Validation(Required=false)]
                public int? LevelType { get; set; }

                /// <summary>
                /// The name of the table level.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the DataWorks workspace.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// The total number of table levels returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
