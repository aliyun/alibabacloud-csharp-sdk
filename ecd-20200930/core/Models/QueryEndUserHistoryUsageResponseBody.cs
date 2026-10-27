// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryEndUserHistoryUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>269BDB16-2CD8-4865-84BD-11C40BC21DB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of users that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of user usage durations on the current page.</para>
        /// </summary>
        [NameInMap("UserUsageInfoList")]
        [Validation(Required=false)]
        public List<QueryEndUserHistoryUsageResponseBodyUserUsageInfoList> UserUsageInfoList { get; set; }
        public class QueryEndUserHistoryUsageResponseBodyUserUsageInfoList : TeaModel {
            /// <summary>
            /// <para>The description of the user. This parameter has a value only for convenience users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test user</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of usage duration details for each cloud desktop.</para>
            /// </summary>
            [NameInMap("DesktopUsageList")]
            [Validation(Required=false)]
            public List<QueryEndUserHistoryUsageResponseBodyUserUsageInfoListDesktopUsageList> DesktopUsageList { get; set; }
            public class QueryEndUserHistoryUsageResponseBodyUserUsageInfoListDesktopUsageList : TeaModel {
                /// <summary>
                /// <para>The ID of the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecd-abc123</para>
                /// </summary>
                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                /// <summary>
                /// <para>The name of the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DemoDesktop</para>
                /// </summary>
                [NameInMap("DesktopName")]
                [Validation(Required=false)]
                public string DesktopName { get; set; }

                /// <summary>
                /// <para>The usage duration of the user on the cloud desktop, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1800</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

            }

            /// <summary>
            /// <para>The display name of the user. For convenience users, this is the real nickname. For AD users, this is the display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The total usage duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The ID of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The username. For convenience users, this is the nickname. For AD users, this is the UserPrincipalName.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

            /// <summary>
            /// <para>The list of organization paths. For convenience users, this includes multiple organization paths. For AD users, this is the OU path.</para>
            /// </summary>
            [NameInMap("OrgPathList")]
            [Validation(Required=false)]
            public List<string> OrgPathList { get; set; }

            /// <summary>
            /// <para>The list of user groups. This parameter has a value only for convenience users.</para>
            /// </summary>
            [NameInMap("UserGroupList")]
            [Validation(Required=false)]
            public List<QueryEndUserHistoryUsageResponseBodyUserUsageInfoListUserGroupList> UserGroupList { get; set; }
            public class QueryEndUserHistoryUsageResponseBodyUserUsageInfoListUserGroupList : TeaModel {
                /// <summary>
                /// <para>The ID of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ug-12345678</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

                /// <summary>
                /// <para>The name of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default user group</para>
                /// </summary>
                [NameInMap("UserGroupName")]
                [Validation(Required=false)]
                public string UserGroupName { get; set; }

            }

        }

    }

}
