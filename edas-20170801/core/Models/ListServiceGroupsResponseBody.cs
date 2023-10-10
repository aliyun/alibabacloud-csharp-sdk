// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListServiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The message that is returned.
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
        /// The information about service groups.
        /// </summary>
        [NameInMap("ServiceGroupsList")]
        [Validation(Required=false)]
        public ListServiceGroupsResponseBodyServiceGroupsList ServiceGroupsList { get; set; }
        public class ListServiceGroupsResponseBodyServiceGroupsList : TeaModel {
            [NameInMap("ListServiceGroups")]
            [Validation(Required=false)]
            public List<ListServiceGroupsResponseBodyServiceGroupsListListServiceGroups> ListServiceGroups { get; set; }
            public class ListServiceGroupsResponseBodyServiceGroupsListListServiceGroups : TeaModel {
                /// <summary>
                /// The time when the service group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The ID of the service group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the service group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

    }

}
