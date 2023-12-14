// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEntityInfoResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEntityInfoResponseBodyData Data { get; set; }
        public class DescribeEntityInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The logical ID of the entity.
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            /// <summary>
            /// The information about the entry.
            /// </summary>
            [NameInMap("EntityInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> EntityInfo { get; set; }

            /// <summary>
            /// The type of the entity. Valid values:
            /// 
            /// *   ip
            /// *   domain
            /// *   url
            /// *   process
            /// *   file
            /// *   host
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// The information about the risk Intelligence.
            /// </summary>
            [NameInMap("TipInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> TipInfo { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
