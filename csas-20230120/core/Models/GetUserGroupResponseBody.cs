// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1310DBC7-7E1F-55D3-B4B4-E4BE912517FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public GetUserGroupResponseBodyUserGroup UserGroup { get; set; }
        public class GetUserGroupResponseBodyUserGroup : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<GetUserGroupResponseBodyUserGroupAttributes> Attributes { get; set; }
            public class GetUserGroupResponseBodyUserGroupAttributes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public int? IdpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Equal</para>
                /// </summary>
                [NameInMap("Relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-10-10 11:39:22</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user_group_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
