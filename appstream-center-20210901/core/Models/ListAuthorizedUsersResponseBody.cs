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
        /// <para>The total number of records that meet the query conditions. This parameter is used to determine whether to continue pagination.</para>
        /// <list type="bullet">
        /// <item><description>When the authorization mode is <c>App</c> or <c>AppInstanceGroup</c>, this value is the number of authorization records. If the same user has multiple authorization records, the user is counted multiple times. Therefore, this value may be greater than the actual number of users.</description></item>
        /// <item><description>When the authorization mode is <c>Session</c>, this value is the number of deduplicated users.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of authorized users on the current page. Multiple authorization records for the same user are merged into one item in the response. If no authorized users meet the conditions, an empty list is returned.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListAuthorizedUsersResponseBodyUsers> Users { get; set; }
        public class ListAuthorizedUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The account type of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>simple: convenience account</description></item>
            /// <item><description>ad: AD domain account from an enterprise AD domain</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>simple</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The application ID. This parameter is returned only when AppId is specified in the request, and the value is the same as the request parameter. This parameter is not returned if AppId is not specified or when querying by app instance group set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-i87mycyn419nu****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The app instance group ID of the authorization relationship to which the user belongs. When querying by app instance group, this value is the same as the request parameter. When querying by app instance group set, this value is the primary app instance group ID of the set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The app instance group set ID. This parameter is returned only when querying by app instance group set, and the value is the same as the AppInstanceGroupSetId request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>set-3jm9d0abc00example</para>
            /// </summary>
            [NameInMap("AppInstanceGroupSetId")]
            [Validation(Required=false)]
            public string AppInstanceGroupSetId { get; set; }

            /// <summary>
            /// <para>The list of persistent session IDs granted to the user. This parameter is returned only when the authorization mode (AuthMode) of the app instance group is <c>Session</c>. This parameter is not affected by the filtering of the AppInstancePersistentId request parameter and always lists all persistent sessions granted to the user.</para>
            /// </summary>
            [NameInMap("AppInstancePersistentIds")]
            [Validation(Required=false)]
            public List<string> AppInstancePersistentIds { get; set; }

            /// <summary>
            /// <para>The authorization mode of the app instance group, which determines the return scope of this operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>App: Application authorization. This mode authorizes the applications under the app instance group to the user and does not restrict which sessions the user can use.</description></item>
            /// <item><description>Session: Session authorization. This mode authorizes the persistent sessions under the app instance group to the user and does not restrict which applications the user can use. In this case, AppInstancePersistentIds returns the persistent sessions granted to the user.</description></item>
            /// <item><description>AppInstanceGroup: App instance group authorization. This mode authorizes the entire app instance group to the user, allowing the user to use any session under the app instance group to open any application.</description></item>
            /// </list>
            /// <para>When querying by app instance group set, the authorization mode of the primary app instance group of the set is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AppInstanceGroup</para>
            /// </summary>
            [NameInMap("AuthMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            /// <summary>
            /// <para>The email address of the user. This parameter is returned only when the account information of the user can be obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The username. To remove authorization, you can pass this value to the UnAuthorizeUserIds parameter of the <a href="~~AuthorizeInstanceGroup~~">AuthorizeInstanceGroup</a> or <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>Specifies whether the current query is not restricted to a specific application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: AppId is not specified in the request, and all authorized users under the app instance group are returned.</description></item>
            /// <item><description>false: AppId is specified in the request, and only the users specifically authorized for this application are returned.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This field is determined by whether the AppId request parameter is specified, and is independent of the actual scope of applications the user is authorized for. You cannot use this field to determine whether the user is authorized for all applications.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAuthAllApps")]
            [Validation(Required=false)]
            public string IsAuthAllApps { get; set; }

            /// <summary>
            /// <para>The phone number of the user. This parameter is returned only when the account information of the user can be obtained.</para>
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
