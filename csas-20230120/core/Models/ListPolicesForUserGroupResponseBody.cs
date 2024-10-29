// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5F04DFBD-3F48-5F70-AE72-474026670128</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<ListPolicesForUserGroupResponseBodyUserGroups> UserGroups { get; set; }
        public class ListPolicesForUserGroupResponseBodyUserGroups : TeaModel {
            [NameInMap("Polices")]
            [Validation(Required=false)]
            public List<ListPolicesForUserGroupResponseBodyUserGroupsPolices> Polices { get; set; }
            public class ListPolicesForUserGroupResponseBodyUserGroupsPolices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>private_access_policy_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pa-policy-ce2bf7236fab****</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PrivateAccess</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>usergroup-6f1ef2fc56b6****</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
