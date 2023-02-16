// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListGroupsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the list of applications.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGroupsResponseBodyData Data { get; set; }
        public class ListGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// The list of applications and details of applications.
            /// </summary>
            [NameInMap("AppGroups")]
            [Validation(Required=false)]
            public List<ListGroupsResponseBodyDataAppGroups> AppGroups { get; set; }
            public class ListGroupsResponseBodyDataAppGroups : TeaModel {
                /// <summary>
                /// 应用分组ID
                /// </summary>
                [NameInMap("AppGroupId")]
                [Validation(Required=false)]
                public long? AppGroupId { get; set; }

                /// <summary>
                /// The key for the application.
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The application description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The application ID.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

            }

        }

        /// <summary>
        /// The additional information returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   **true**: The call is successful.
        /// *   **false**: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
