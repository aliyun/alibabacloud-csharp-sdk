// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListGroupsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the applications.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGroupsResponseBodyData Data { get; set; }
        public class ListGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// The applications and their details.
            /// </summary>
            [NameInMap("AppGroups")]
            [Validation(Required=false)]
            public List<ListGroupsResponseBodyDataAppGroups> AppGroups { get; set; }
            public class ListGroupsResponseBodyDataAppGroups : TeaModel {
                /// <summary>
                /// The application group ID.
                /// </summary>
                [NameInMap("AppGroupId")]
                [Validation(Required=false)]
                public long? AppGroupId { get; set; }

                /// <summary>
                /// The AppKey for the application.
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
                /// The description of the application.
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
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
