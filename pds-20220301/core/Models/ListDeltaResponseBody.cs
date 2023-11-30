// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListDeltaResponseBody : TeaModel {
        /// <summary>
        /// The cursor of the incremental information.
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Indicates whether more information is returned.
        /// </summary>
        [NameInMap("has_more")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// The incremental information returned.
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListDeltaResponseBodyItems> Items { get; set; }
        public class ListDeltaResponseBodyItems : TeaModel {
            /// <summary>
            /// The information about the file.
            /// </summary>
            [NameInMap("file")]
            [Validation(Required=false)]
            public File File { get; set; }

            /// <summary>
            /// The file ID.
            /// </summary>
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// The operation that is performed. Valid values: Valid values:
            /// 
            /// *   create
            /// *   overwrite
            /// *   delete
            /// *   update
            /// *   move
            /// *   trash
            /// *   restore
            /// *   rename
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

        }

    }

}
