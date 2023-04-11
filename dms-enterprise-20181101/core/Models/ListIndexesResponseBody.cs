// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListIndexesResponseBody : TeaModel {
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
        /// The details of indexes.
        /// </summary>
        [NameInMap("IndexList")]
        [Validation(Required=false)]
        public ListIndexesResponseBodyIndexList IndexList { get; set; }
        public class ListIndexesResponseBodyIndexList : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public List<ListIndexesResponseBodyIndexListIndex> Index { get; set; }
            public class ListIndexesResponseBodyIndexListIndex : TeaModel {
                /// <summary>
                /// The description of the index.
                /// </summary>
                [NameInMap("IndexComment")]
                [Validation(Required=false)]
                public string IndexComment { get; set; }

                /// <summary>
                /// The ID of the index.
                /// </summary>
                [NameInMap("IndexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                /// <summary>
                /// The name of the index.
                /// </summary>
                [NameInMap("IndexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                /// <summary>
                /// The type of the index. Valid values:
                /// 
                /// *   Primary
                /// *   Unique
                /// *   Normal
                /// *   FullText
                /// *   Spatial
                /// </summary>
                [NameInMap("IndexType")]
                [Validation(Required=false)]
                public string IndexType { get; set; }

                /// <summary>
                /// The ID of the table.
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
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
