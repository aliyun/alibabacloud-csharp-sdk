// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetGroupResponseBody : TeaModel {
        /// <summary>
        /// The information about the account group.
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public GetGroupResponseBodyGroup Group { get; set; }
        public class GetGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// The time at which the group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The description of the group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The external ID of the group, which can be used to associate the group with an external system. By default, the external ID is the group ID.
            /// </summary>
            [NameInMap("GroupExternalId")]
            [Validation(Required=false)]
            public string GroupExternalId { get; set; }

            /// <summary>
            /// The group ID.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The source ID of the group. By default, the source ID is the instance ID.
            /// </summary>
            [NameInMap("GroupSourceId")]
            [Validation(Required=false)]
            public string GroupSourceId { get; set; }

            /// <summary>
            /// The source type of the group. Only build_in may be returned, which indicates that the group was created in IDaaS.
            /// 
            /// *build_in：Create By Self。
            /// </summary>
            [NameInMap("GroupSourceType")]
            [Validation(Required=false)]
            public string GroupSourceType { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The time at which the group was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
