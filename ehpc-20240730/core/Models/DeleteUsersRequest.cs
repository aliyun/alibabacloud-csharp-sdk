// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class DeleteUsersRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The users that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public List<DeleteUsersRequestUser> User { get; set; }
        public class DeleteUsersRequestUser : TeaModel {
            /// <summary>
            /// <para>The name of user N that you want to delete.</para>
            /// <para>Valid values of N: 1 to 100.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuser</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
