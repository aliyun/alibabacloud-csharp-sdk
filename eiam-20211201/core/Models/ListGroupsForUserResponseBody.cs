// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListGroupsForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<ListGroupsForUserResponseBodyGroups> Groups { get; set; }
        public class ListGroupsForUserResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The source ID of the group member relationship. For self-managed groups, the default value is the instance ID. For other types, the value corresponds to the enterprise ID of the source. For example, if the source is DingTalk, the value is the corpId of the DingTalk enterprise.</para>
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
            /// <item><description>build_in: Self-managed.</description></item>
            /// <item><description>ding_talk: Imported from DingTalk.</description></item>
            /// <item><description>ad: Imported from AD.</description></item>
            /// <item><description>ldap: Imported from LDAP.</description></item>
            /// <item><description>we_com: Imported from WeCom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>build_in</para>
            /// </summary>
            [NameInMap("GroupMemberRelationSourceType")]
            [Validation(Required=false)]
            public string GroupMemberRelationSourceType { get; set; }

        }

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
        /// <para>The total number of matched entries. The maximum number of entries returned per page is specified by the PageSize parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
