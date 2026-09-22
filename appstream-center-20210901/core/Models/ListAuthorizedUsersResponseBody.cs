// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number, which is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page, which is the same as the PageSize request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C1A4F2D-713A-5C98-8AF6-1B5D0868****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the query conditions. Use this value to determine whether to continue paging.</para>
        /// <list type="bullet">
        /// <item><description>When the authorization mode is <c>App</c> or <c>AppInstanceGroup</c>, this is the number of authorization records. If the same user has multiple authorization records, the user is counted multiple times. Therefore, this value may be greater than the actual number of users.</description></item>
        /// <item><description>When the authorization mode is <c>Session</c>, this is the deduplicated user count.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of authorized users on the current page. Multiple authorization records for the same user are merged into a single entry. An empty list is returned if no authorized users match the conditions.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListAuthorizedUsersResponseBodyUsers> Users { get; set; }
        public class ListAuthorizedUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The account type of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>simple: Convenience account.</description></item>
            /// <item><description>ad: Active Directory (AD) domain account, which originates from an enterprise AD domain.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>simple</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The application ID. Returned only when AppId is specified in the request. The value is the same as the request parameter. Not returned if AppId is not specified or when querying by delivery group set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-i87mycyn419nu****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The delivery group ID associated with the user\&quot;s authorization relationship. When querying by delivery group, this value is the same as the request parameter. When querying by delivery group set, this value is the primary delivery group ID of the set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The delivery group set ID. Returned only when querying by delivery group set. The value is the same as the AppInstanceGroupSetId request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>set-3jm9d0abc00example</para>
            /// </summary>
            [NameInMap("AppInstanceGroupSetId")]
            [Validation(Required=false)]
            public string AppInstanceGroupSetId { get; set; }

            /// <summary>
            /// <para>The list of persistent session IDs granted to the user. Returned only when the delivery group authorization mode (AuthMode) is <c>Session</c>. This list is not affected by the AppInstancePersistentId request parameter and always includes all persistent sessions granted to the user.</para>
            /// </summary>
            [NameInMap("AppInstancePersistentIds")]
            [Validation(Required=false)]
            public List<string> AppInstancePersistentIds { get; set; }

            /// <summary>
            /// <para>The authorization mode of the delivery group, which determines the scope of results returned by this operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>App: Application-level authorization. Applications within the delivery group are authorized to users without restricting which sessions the users can use.</description></item>
            /// <item><description>Session: Session-level authorization. Persistent sessions within the delivery group are authorized to users without restricting which applications the users can use. In this case, AppInstancePersistentIds returns the persistent sessions granted to the user.</description></item>
            /// <item><description>AppInstanceGroup: Delivery group-level authorization. The entire delivery group is authorized to users, allowing them to open any application using any session within the delivery group.</description></item>
            /// </list>
            /// <para>When querying by delivery group set, the authorization mode of the primary delivery group in the set is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AppInstanceGroup</para>
            /// </summary>
            [NameInMap("AuthMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            /// <summary>
            /// <para>The email address of the user. Returned only when the account information of the user can be retrieved.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The username. To remove authorization, pass this value to the UnAuthorizeUserIds parameter of the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> or <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation.</para>
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
            /// <item><description>true: AppId is not specified in the request. All authorized users under the delivery group are returned.</description></item>
            /// <item><description>false: AppId is specified in the request. Only users authorized for that specific application are returned.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This field is determined by whether the AppId request parameter is specified. It does not reflect the actual scope of applications authorized to the user and cannot be used to determine whether the user is authorized for all applications.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAuthAllApps")]
            [Validation(Required=false)]
            public string IsAuthAllApps { get; set; }

            /// <summary>
            /// <para>The phone number of the user. Returned only when the account information of the user can be retrieved.</para>
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
