// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyUserPasswordsRequest : TeaModel {
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
        public List<ModifyUserPasswordsRequestUser> User { get; set; }
        public class ModifyUserPasswordsRequestUser : TeaModel {
            /// <summary>
            /// The name of the user N whose password you want to modify. Valid values of N: 1 to 100.
            /// 
            /// You can call the [ListUsers](~~188572~~) operation to query the users of the cluster.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The password of the Nth user. The password must be 8 to 30 characters in length and contain three of the following items:
            /// 
            /// *   Uppercase letter
            /// *   Lowercase letter
            /// *   Digit
            /// *   Special character: `()~!@#$%^&*-_+=|{}[]:;\"/<>,.?/`
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// >  We recommend that you use HTTPS to call API operations to avoid password leaks.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

    }

}
