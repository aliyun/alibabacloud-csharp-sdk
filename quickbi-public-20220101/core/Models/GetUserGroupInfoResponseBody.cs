// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetUserGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D7980306-1F08-5A88-9FE7-ECB8B9C4C0F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetUserGroupInfoResponseBodyResult> Result { get; set; }
        public class GetUserGroupInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-15 17:13:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>46e5374665ba4b679ee22e2a2927****</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            [NameInMap("IdentifiedPath")]
            [Validation(Required=false)]
            public string IdentifiedPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-15 20:36:40</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>46e5374665ba4b679ee22e2a2927****</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2fe4fbd8-588f-489a-b3e1-e92c7af0****</para>
            /// </summary>
            [NameInMap("ParentUsergroupId")]
            [Validation(Required=false)]
            public string ParentUsergroupId { get; set; }

            [NameInMap("UsergroupDesc")]
            [Validation(Required=false)]
            public string UsergroupDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>34fd141d-4598-4093-8c33-8e066dcb****</para>
            /// </summary>
            [NameInMap("UsergroupId")]
            [Validation(Required=false)]
            public string UsergroupId { get; set; }

            [NameInMap("UsergroupName")]
            [Validation(Required=false)]
            public string UsergroupName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
