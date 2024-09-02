// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListQueryProcessorNersResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The priority settings of entity types.
        /// 
        /// For more information, see [Priority settings of entity types](https://help.aliyun.com/document_detail/173616.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListQueryProcessorNersResponseBodyResult> Result { get; set; }
        public class ListQueryProcessorNersResponseBodyResult : TeaModel {
            /// <summary>
            /// The name of the entity type.
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// The priority of an entity type among entity types that have the same priority level. A smaller value indicates a higher priority. Default value: 0.
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// The priority level of the entity type. Valid values:
            /// 
            /// *   HIGH
            /// *   MIDDLE
            /// *   LOW
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// The internal name of the entity type.
            /// </summary>
            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

    }

}
