// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyInstanceMemberAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The members that to be modified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<ModifyInstanceMemberAttributesRequestMembers> Members { get; set; }
        public class ModifyInstanceMemberAttributesRequestMembers : TeaModel {
            /// <summary>
            /// <para>The remarks of the member in Cloud Firewall.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>renewal</para>
            /// </summary>
            [NameInMap("MemberDesc")]
            [Validation(Required=false)]
            public string MemberDesc { get; set; }

            /// <summary>
            /// <para>The UID of the member in Cloud Firewall.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123412341234****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

        }

    }

}
