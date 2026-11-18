// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersForGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matched entries. The maximum number of entries returned on a single page is specified by the PageSize parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of account object information.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersForGroupResponseBodyUsers> Users { get; set; }
        public class ListUsersForGroupResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The source ID of the group member relationship. For the self-managed type, the default value is the instance ID. For other types, the value corresponds to the enterprise ID of the source. For example, if the source is DingTalk, the value is the corpId of the DingTalk enterprise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("GroupMemberRelationSourceId")]
            [Validation(Required=false)]
            public string GroupMemberRelationSourceId { get; set; }

            /// <summary>
            /// <para>The source type of the group member relationship. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>build_in: self-managed</description></item>
            /// <item><description>ding_talk: imported from DingTalk</description></item>
            /// <item><description>ad: imported from AD</description></item>
            /// <item><description>ldap: imported from LDAP</description></item>
            /// <item><description>we_com: imported from WeCom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>build_in</para>
            /// </summary>
            [NameInMap("GroupMemberRelationSourceType")]
            [Validation(Required=false)]
            public string GroupMemberRelationSourceType { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
