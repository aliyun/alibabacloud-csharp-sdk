// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPublishedAppsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application used for filtering. Substring matching is supported. You can pass the complete ID or a continuous segment of it. If this parameter is not specified or an empty string is passed, filtering is not performed based on the application ID. If this parameter and <c>AppName</c> are specified at the same time, both conditions must be met by the same application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the delivery group used for filtering. Substring matching is supported. You can pass the complete ID or a continuous segment of it. If this parameter is not specified or an empty string is passed, filtering is not performed based on the delivery group ID. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID. This parameter can be used together with other filter conditions, and all conditions must be met.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the delivery group used for filtering. Substring matching is supported. For example, if you pass <c>Office applications</c>, delivery groups whose names contain this text are matched. If this parameter is not specified or an empty string is passed, filtering is not performed based on the delivery group name. If this parameter and the delivery group ID are specified at the same time, both conditions must be met.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The name of the application used for filtering. Substring matching is supported. For example, if you pass <c>Office applications</c>, applications whose names contain this text are matched. If this parameter is not specified or an empty string is passed, filtering is not performed based on the application name. If this parameter and <c>AppId</c> are specified at the same time, both conditions must be met by the same application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The username to be excluded. Exact matching is performed based on the full username, such as <c>alice</c>. If this parameter is specified, applications that have been authorized for this user on a per-application basis through <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> are not returned. This can be used to find applications that can still be authorized for the user. If this parameter is not specified or an empty string is passed, filtering is not performed based on user authorization.</para>
        /// <para><b>Access permissions obtained through overall delivery group authorization or user groups are not evaluated by this condition.</b> Do not equate the returned results with a list of applications that the user has absolutely no access to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("ExcludeUserId")]
        [Validation(Required=false)]
        public string ExcludeUserId { get; set; }

        /// <summary>
        /// <para>The page number. This parameter is required. Start the query from page <c>1</c> and use it in conjunction with <c>PageSize</c>. Keep other filter conditions unchanged when querying subsequent pages. If the value is invalid, the error code <c>InvalidParameter.PageNumber</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of application records to return per page. This parameter is required. Valid values: <c>1</c> to <c>100</c>. If the value is out of range, the error code <c>InvalidParameter.PageSize</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. This parameter is required and is not case-sensitive. Only applications in published delivery groups of this product type are returned. If an unrecognized value is passed, the error code <c>InvalidParameter.ProductType</c> is returned. Filtering and statistics related to per-application authorization (<c>ExcludeUserId</c> and <c>AuthorizedUserCount</c>) are primarily used in WUYING Cloud App scenarios.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: WUYING Cloud App.</description></item>
        /// <item><description><c>CloudBrowser</c>: Cloud browser.</description></item>
        /// <item><description><c>WuyingServer</c>: Enterprise Edition workstation.</description></item>
        /// <item><description><c>WuyingWorkstation</c>: Personal Edition Linggou container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationTeam</c>: Team Edition Linggou container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationBusiness</c>: Dedicated Edition Linggou container workstation.</description></item>
        /// <item><description><c>AndroidCloud</c>: Cloud phone.</description></item>
        /// <item><description><c>AIAgent</c>: AgentBay (AI agent).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
