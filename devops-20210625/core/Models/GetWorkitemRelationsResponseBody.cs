// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkitemRelationsResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("relationList")]
        [Validation(Required=false)]
        public List<GetWorkitemRelationsResponseBodyRelationList> RelationList { get; set; }
        public class GetWorkitemRelationsResponseBodyRelationList : TeaModel {
            [NameInMap("assignedTo")]
            [Validation(Required=false)]
            public string AssignedTo { get; set; }

            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("spaceIdentifier")]
            [Validation(Required=false)]
            public string SpaceIdentifier { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("workitemTypeIdentifier")]
            [Validation(Required=false)]
            public string WorkitemTypeIdentifier { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
