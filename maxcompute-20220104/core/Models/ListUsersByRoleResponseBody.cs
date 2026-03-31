// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListUsersByRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListUsersByRoleResponseBodyData Data { get; set; }
        public class ListUsersByRoleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The users.</para>
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<ListUsersByRoleResponseBodyDataUsers> Users { get; set; }
            public class ListUsersByRoleResponseBodyDataUsers : TeaModel {
                /// <summary>
                /// <para>The name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN${account_name}</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0be3e0bb16654558425251398e27a9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
