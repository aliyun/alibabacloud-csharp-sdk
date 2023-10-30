// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostGroupsForUserResponseBody : TeaModel {
        /// <summary>
        /// ListHostGroupsForUser
        /// </summary>
        [NameInMap("HostGroups")]
        [Validation(Required=false)]
        public List<ListHostGroupsForUserResponseBodyHostGroups> HostGroups { get; set; }
        public class ListHostGroupsForUserResponseBodyHostGroups : TeaModel {
            /// <summary>
            /// ListHostGroupsForUser
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// WB662865
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            [NameInMap("HostGroupName")]
            [Validation(Required=false)]
            public string HostGroupName { get; set; }

        }

        /// <summary>
        /// Queries the host groups that a specified user is authorized or not authorized to manage.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// All Bastionhost API requests must include common request parameters. For more information about common request parameters, see [Common parameters](~~148139~~).
        /// 
        /// For more information about sample requests, see the "Examples" section of this topic.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
