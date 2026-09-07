// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryEndUserHistoryUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
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
        /// <para>The list of user usage duration entries on the current page.</para>
        /// </summary>
        [NameInMap("UserUsageInfoList")]
        [Validation(Required=false)]
        public List<QueryEndUserHistoryUsageResponseBodyUserUsageInfoList> UserUsageInfoList { get; set; }
        public class QueryEndUserHistoryUsageResponseBodyUserUsageInfoList : TeaModel {
            /// <summary>
            /// <para>The remarks of the user. This parameter has a value only for convenience account users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test user</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of usage duration details for each desktop.</para>
            /// </summary>
            [NameInMap("DesktopUsageList")]
            [Validation(Required=false)]
            public List<QueryEndUserHistoryUsageResponseBodyUserUsageInfoListDesktopUsageList> DesktopUsageList { get; set; }
            public class QueryEndUserHistoryUsageResponseBodyUserUsageInfoListDesktopUsageList : TeaModel {
                /// <summary>
                /// <para>The desktop ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecd-abc123</para>
                /// </summary>
                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                /// <summary>
                /// <para>The desktop name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DemoDesktop</para>
                /// </summary>
                [NameInMap("DesktopName")]
                [Validation(Required=false)]
                public string DesktopName { get; set; }

                /// <summary>
                /// <para>The usage duration of the user on the desktop, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1800</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

            }

            /// <summary>
            /// <para>The display name of the user. For convenience account users, this is the actual nickname. For AD users, this is the display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John Smith</para>
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
            /// <para>The end user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The username. For convenience account users, this is the nickname. For AD users, this is the UserPrincipalName.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

            /// <summary>
            /// <para>The list of organization paths. For convenience account users, this contains multiple organization paths. For AD users, this is the organizational unit (OU) path.</para>
            /// </summary>
            [NameInMap("OrgPathList")]
            [Validation(Required=false)]
            public List<string> OrgPathList { get; set; }

            /// <summary>
            /// <para>The list of user groups. This parameter has a value only for convenience account users.</para>
            /// </summary>
            [NameInMap("UserGroupList")]
            [Validation(Required=false)]
            public List<QueryEndUserHistoryUsageResponseBodyUserUsageInfoListUserGroupList> UserGroupList { get; set; }
            public class QueryEndUserHistoryUsageResponseBodyUserUsageInfoListUserGroupList : TeaModel {
                /// <summary>
                /// <para>The user group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ug-12345678</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

                /// <summary>
                /// <para>The user group name.</para>
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
