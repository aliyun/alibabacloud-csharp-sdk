// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RegisterLineageRelationResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("LineageRelation")]
        [Validation(Required=false)]
        public RegisterLineageRelationResponseBodyLineageRelation LineageRelation { get; set; }
        public class RegisterLineageRelationResponseBodyLineageRelation : TeaModel {
            [NameInMap("DestEntityQualifiedName")]
            [Validation(Required=false)]
            public string DestEntityQualifiedName { get; set; }

            [NameInMap("RelationshipGuid")]
            [Validation(Required=false)]
            public string RelationshipGuid { get; set; }

            [NameInMap("SrcEntityQualifiedName")]
            [Validation(Required=false)]
            public string SrcEntityQualifiedName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
