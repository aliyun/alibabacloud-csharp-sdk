// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RegisterLineageRelationResponseBody : TeaModel {
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
        /// The lineage.
        /// </summary>
        [NameInMap("LineageRelation")]
        [Validation(Required=false)]
        public RegisterLineageRelationResponseBodyLineageRelation LineageRelation { get; set; }
        public class RegisterLineageRelationResponseBodyLineageRelation : TeaModel {
            /// <summary>
            /// The unique identifier of the destination entity.
            /// </summary>
            [NameInMap("DestEntityQualifiedName")]
            [Validation(Required=false)]
            public string DestEntityQualifiedName { get; set; }

            /// <summary>
            /// The ID of the lineage between entities.
            /// </summary>
            [NameInMap("RelationshipGuid")]
            [Validation(Required=false)]
            public string RelationshipGuid { get; set; }

            /// <summary>
            /// The unique identifier of the source entity.
            /// </summary>
            [NameInMap("SrcEntityQualifiedName")]
            [Validation(Required=false)]
            public string SrcEntityQualifiedName { get; set; }

        }

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
