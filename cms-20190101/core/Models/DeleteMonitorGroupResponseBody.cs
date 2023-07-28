// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMonitorGroupResponseBody : TeaModel {
        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public DeleteMonitorGroupResponseBodyGroup Group { get; set; }
        public class DeleteMonitorGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// The name of the alert group.
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public DeleteMonitorGroupResponseBodyGroupContactGroups ContactGroups { get; set; }
            public class DeleteMonitorGroupResponseBodyGroupContactGroups : TeaModel {
                [NameInMap("ContactGroup")]
                [Validation(Required=false)]
                public List<DeleteMonitorGroupResponseBodyGroupContactGroupsContactGroup> ContactGroup { get; set; }
                public class DeleteMonitorGroupResponseBodyGroupContactGroupsContactGroup : TeaModel {
                    /// <summary>
                    /// Deletes an application group.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// The alert groups that receive alert notifications for the application group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. The value true indicates a success. The value false indicates a failure.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The deleted application group.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
