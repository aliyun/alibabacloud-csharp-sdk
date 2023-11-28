// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictsResponseBody : TeaModel {
        /// <summary>
        /// The header of the response.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDictsResponseBodyHeaders Headers { get; set; }
        public class ListDictsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDictsResponseBodyResult> Result { get; set; }
        public class ListDictsResponseBodyResult : TeaModel {
            /// <summary>
            /// The link that is used to download the dictionary over the Internet. The link is valid for 90s.
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// The size of the dictionary file. Unit: byte.
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// The name of the dictionary file.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The source type.
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The type of the IK dictionary. Valid values:
            /// 
            /// *   MAIN: main dictionary
            /// *   STOP: stopword list
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
