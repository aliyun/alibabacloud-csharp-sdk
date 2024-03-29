// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyUserGroupsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the asynchronous mode for this request.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to obtain the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The information about the user.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public List<ModifyUserGroupsRequestUser> User { get; set; }
        public class ModifyUserGroupsRequestUser : TeaModel {
            /// <summary>
            /// The new permission group of the user N. Valid values:
            /// 
            /// *   users: an ordinary permission group. It is applicable to ordinary users that need only to submit and debug jobs.
            /// *   wheel: a sudo permission group. It is applicable to the administrator who needs to manage the cluster. In addition to submitting and debugging jobs, users who have sudo permissions can run sudo commands to install software and restart nodes.
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// The name of the user N whose permissions you want to modify. Valid values of N: 1 to 100.
            /// 
            /// You can call the [ListUsers](~~188572~~) operation to query the users of the cluster.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
