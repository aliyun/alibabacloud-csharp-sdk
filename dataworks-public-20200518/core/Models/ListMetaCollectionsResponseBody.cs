// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMetaCollectionsResponseBody : TeaModel {
        /// <summary>
        /// The token that is used for the next query.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMetaCollectionsResponseBodyData Data { get; set; }
        public class ListMetaCollectionsResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the request was successful. Valid values:
            /// 
            /// *   true: The request was successful.
            /// *   false: The request failed.
            /// </summary>
            [NameInMap("CollectionList")]
            [Validation(Required=false)]
            public List<Collection> CollectionList { get; set; }

            /// <summary>
            /// The collections.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The object returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
