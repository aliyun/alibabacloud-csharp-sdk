// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class AssociateMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the contact was bound to the object.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<AssociateMembersResponseBodyMembers> Members { get; set; }
        public class AssociateMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <para>The ID of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-qL4HqKONzOM7****</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>The ID of the object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ID of the resource directory</description></item>
            /// <item><description>ID of the folder</description></item>
            /// <item><description>ID of the member</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fd-ZDNPiT****</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <para>The time when the contact was bound to the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-27 17:19:21</para>
            /// </summary>
            [NameInMap("ModifyDate")]
            [Validation(Required=false)]
            public string ModifyDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95060F1D-6990-4645-8920-A81D1BBFE992</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
