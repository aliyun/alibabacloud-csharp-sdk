// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProjectUsersResponseBodyData Data { get; set; }
        public class ListProjectUsersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array that contains users.</para>
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<ListProjectUsersResponseBodyDataUsers> Users { get; set; }
            public class ListProjectUsersResponseBodyDataUsers : TeaModel {
                /// <summary>
                /// <para>The name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b87b7b316643495896551555e855b</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
