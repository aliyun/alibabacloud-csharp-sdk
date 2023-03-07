// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddUsersRequest : TeaModel {
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public List<AddUsersRequestUser> User { get; set; }
        public class AddUsersRequestUser : TeaModel {
            /// <summary>
            /// The permission group to which the user belongs. Valid values:
            /// 
            /// *   users: an ordinary permission group. It is applicable to ordinary users that need only to submit and debug jobs.
            /// *   wheel: a sudo permission group. It is applicable to the administrator who needs to manage the cluster. In addition to submitting and debugging jobs, users who have sudo permissions can run sudo commands to install software and restart nodes.
            /// 
            /// Valid values of N: 1 to 100
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// The name of the user that you want to add. The name must be 6 to 30 characters in length and can contain letters, digits, and periods (.). It must start with a letter.
            /// 
            /// Valid values of N: 1 to 100
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The password of the user. The password must be 8 to 30 characters in length and contain three of the following items:
            /// 
            /// *   Uppercase letter
            /// *   Lowercase letter
            /// *   Digit
            /// *   Special character: `()~!@#$%^&*-_+=|{}[]:;\"/<>,.?/`
            /// 
            /// Valid values of N: 1 to 100
            /// 
            /// >  We recommend that you use HTTPS to call the AddUsers operation to ensure that the password remains confidential.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

    }

}
