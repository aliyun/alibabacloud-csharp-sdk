// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5F04DFBD-3F48-5F70-AE72-474026670128</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of user groups.</para>
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<ListPolicesForUserGroupResponseBodyUserGroups> UserGroups { get; set; }
        public class ListPolicesForUserGroupResponseBodyUserGroups : TeaModel {
            /// <summary>
            /// <para>The policies.</para>
            /// </summary>
            [NameInMap("Polices")]
            [Validation(Required=false)]
            public List<ListPolicesForUserGroupResponseBodyUserGroupsPolices> Polices { get; set; }
            public class ListPolicesForUserGroupResponseBodyUserGroupsPolices : TeaModel {
                /// <summary>
                /// <para>The name of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>private_access_policy_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-policy-ce2bf7236fab****</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <para>The policy type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>PrivateAccess</b>: private network access.</para>
                /// </description></item>
                /// <item><description><para><b>URLFilter</b>: URL filtering.</para>
                /// </description></item>
                /// <item><description><para><b>AppAccessControl</b>: application control.</para>
                /// </description></item>
                /// <item><description><para><b>DLP</b>: Data Leakage Prevention.</para>
                /// </description></item>
                /// <item><description><para><b>NAC</b>: Network Access Control.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateAccess</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usergroup-6f1ef2fc56b6****</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
