// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteUsersRequest : TeaModel {
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
        public List<DeleteUsersRequestUser> User { get; set; }
        public class DeleteUsersRequestUser : TeaModel {
            /// <summary>
            /// The name of the user N that you want to delete. Valid values of N: 1 to 100.
            /// 
            /// You can call the [ListUsers](~~188572~~) operation to query the users of the cluster.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
