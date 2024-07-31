// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceGroupResponseBody : TeaModel {
        /// <summary>
        /// The details of the business process.
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public GetDataServiceGroupResponseBodyGroup Group { get; set; }
        public class GetDataServiceGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// The ID of the API group that is associated with the business process in the API Gateway console.
            /// </summary>
            [NameInMap("ApiGatewayGroupId")]
            [Validation(Required=false)]
            public string ApiGatewayGroupId { get; set; }

            /// <summary>
            /// The time when the business process was created.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The user identifier (UID) of the creator of the business process. The value of this parameter may be empty for creators of some existing business processes.
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// The description of the business process.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The business process ID.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the business process.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The time when the business process was last modified.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The workspace ID.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The tenant ID.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
