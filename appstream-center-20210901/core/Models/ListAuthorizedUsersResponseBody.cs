// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C1A4F2D-713A-5C98-8AF6-1B5D0868****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of authorization records that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of authorized users on the current page. An empty list is returned if no authorization records are matched.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListAuthorizedUsersResponseBodyUsers> Users { get; set; }
        public class ListAuthorizedUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The user account type.</para>
            /// <list type="bullet">
            /// <item><description><c>simple</c>: convenience account.</description></item>
            /// <item><description><c>ad</c>: Active Directory (AD) domain account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>simple</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The application ID specified in this query. This field is not returned if no application filter condition is specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-3jm9d0abc00example</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The delivery group ID to which the authorization relationship belongs. When querying cloud browsers, this is the browser group ID. When querying by set, this field is the primary delivery group ID of the set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>big-3jm9d0abc00example</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The delivery group set ID of this query. This field is returned when querying by set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>set-3jm9d0abc00example</para>
            /// </summary>
            [NameInMap("AppInstanceGroupSetId")]
            [Validation(Required=false)]
            public string AppInstanceGroupSetId { get; set; }

            /// <summary>
            /// <para>The list of persistent session IDs authorized to the user. This field is returned when the authorization mode is <c>Session</c>.</para>
            /// </summary>
            [NameInMap("AppInstancePersistentIds")]
            [Validation(Required=false)]
            public List<string> AppInstancePersistentIds { get; set; }

            /// <summary>
            /// <para>The authorization mode of the delivery group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>App</c>: Authorization by application.</description></item>
            /// <item><description><c>Session</c>: Authorization by persistent session.</description></item>
            /// <item><description><c>AppInstanceGroup</c>: Authorization by delivery group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AppInstanceGroup</para>
            /// </summary>
            [NameInMap("AuthMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            /// <summary>
            /// <para>The email address of the user. This field may not be returned if the email address is not available.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The authorized username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>Indicates whether the query is not restricted to a specific application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: No application filter condition is specified.</description></item>
            /// <item><description><c>false</c>: An application filter condition is specified.</description></item>
            /// </list>
            /// <para>This field is determined by the query conditions and cannot be used alone to determine whether the user is authorized for all applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAuthAllApps")]
            [Validation(Required=false)]
            public string IsAuthAllApps { get; set; }

            /// <summary>
            /// <para>The phone number of the user. This field may not be returned if the phone number is not available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>138****0000</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

        }

    }

}
