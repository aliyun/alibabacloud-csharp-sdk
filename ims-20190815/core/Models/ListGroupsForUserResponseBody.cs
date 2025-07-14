// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListGroupsForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the RAM user groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public ListGroupsForUserResponseBodyGroups Groups { get; set; }
        public class ListGroupsForUserResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<ListGroupsForUserResponseBodyGroupsGroup> Group { get; set; }
            public class ListGroupsForUserResponseBodyGroupsGroup : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test-Team</para>
                /// </summary>
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                /// <summary>
                /// <para>The display name of the RAM user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test-Team</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The ID of the RAM user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>740317625433843****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the RAM user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test-Team</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The time when the RAM user was added.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-20T06:57:00Z</para>
                /// </summary>
                [NameInMap("JoinDate")]
                [Validation(Required=false)]
                public string JoinDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7158A935-FB5E-49A7-8E52-FDA5B2B67247</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
