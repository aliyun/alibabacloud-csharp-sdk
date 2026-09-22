// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPublishedAppsRequest : TeaModel {
        /// <summary>
        /// <para>The application ID used for filtering. Substring matching is supported. You can specify a complete ID or a consecutive segment of it. If this parameter is not specified or is set to an empty string, filtering by application ID is not applied. If both this parameter and <c>AppName</c> are specified, both conditions must be met by the same application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery group ID used for filtering. Substring matching is supported. You can specify a complete ID or a consecutive segment of it. If this parameter is not specified or is set to an empty string, filtering by delivery group ID is not applied. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain delivery group IDs. This parameter can be used together with other filter conditions, and all conditions must be met simultaneously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group name used for filtering. Substring matching is supported. For example, if you specify <c>OfficeApps</c>, delivery groups whose names contain this text are matched. If this parameter is not specified or is set to an empty string, filtering by delivery group name is not applied. If both this parameter and the delivery group ID are specified, both conditions must be met.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OfficeApps</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The application name used for filtering. Substring matching is supported. For example, if you specify <c>OfficeApps</c>, applications whose names contain this text are matched. If this parameter is not specified or is set to an empty string, filtering by application name is not applied. If both this parameter and <c>AppId</c> are specified, both conditions must be met by the same application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OfficeApps</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The username to exclude. Exact username matching is used. For example, <c>alice</c>. When specified, applications that have been authorized to this user through <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> by application are not returned. This helps you find applications that can still be authorized to the user. If this parameter is not specified or is set to an empty string, no exclusion based on user authorization is applied.</para>
        /// <para><b>Access permissions granted through delivery-group-level authorization or user groups are not evaluated by this condition.</b> The returned results cannot be treated as a complete list of applications that the user has no access to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("ExcludeUserId")]
        [Validation(Required=false)]
        public string ExcludeUserId { get; set; }

        /// <summary>
        /// <para>The page number. This parameter is required. Start from page <c>1</c> and use this parameter together with <c>PageSize</c>. Keep other filter conditions unchanged when querying subsequent pages. If an invalid value is specified, the error code <c>InvalidParameter.PageNumber</c> is returned.</para>
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
        /// <para>The product type. This parameter is required. The value is case-insensitive. Only applications in published delivery groups of the specified product type are returned. If an unrecognized value is specified, the error code <c>InvalidParameter.ProductType</c> is returned. Filtering and statistics related to per-application authorization (<c>ExcludeUserId</c> and <c>AuthorizedUserCount</c>) are primarily used in WUYING Cloud Application common scenarios.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: WUYING Cloud Application.</description></item>
        /// <item><description><c>CloudBrowser</c>: Cloud Browser.</description></item>
        /// <item><description><c>WuyingServer</c>: Enterprise Workstation.</description></item>
        /// <item><description><c>WuyingWorkstation</c>: Personal Edition Lingjou Container Workstation.</description></item>
        /// <item><description><c>WuyingWorkstationTeam</c>: Team Edition Lingjou Container Workstation.</description></item>
        /// <item><description><c>WuyingWorkstationBusiness</c>: Dedicated Edition Lingjou Container Workstation.</description></item>
        /// <item><description><c>AndroidCloud</c>: Cloud Phone.</description></item>
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
