// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPublishedAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The application ID used for filtering delivery groups. Substring matching is supported. The delivery group must contain a deployed application that matches the condition. If this parameter is not specified or is set to an empty string, no filtering by application ID is applied. When specified together with <c>AppName</c>, the same application must satisfy both conditions.</para>
        /// <para>This condition does not trim the returned <c>Apps</c> list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery group ID used for filtering. Substring matching is supported. You can pass in a full ID or a consecutive segment of the ID. If this parameter is not specified or is set to an empty string, no filtering by ID is applied. This parameter can be used together with other filter conditions. Results must satisfy all conditions simultaneously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group name used for filtering. Substring matching is supported. For example, if you pass in <c>OfficeApps</c>, delivery groups whose names contain this text are matched. If this parameter is not specified or is set to an empty string, no filtering by name is applied. When specified together with the delivery group ID, both the ID and name must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OfficeApps</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The application name used for filtering delivery groups. Substring matching is supported. The delivery group must contain a deployed application whose name includes the specified text. If this parameter is not specified or is set to an empty string, no filtering by application name is applied. When specified together with <c>AppId</c>, the same application must satisfy both conditions.</para>
        /// <para>This condition does not trim the returned <c>Apps</c> list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OfficeApps</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The username to exclude based on existing authorization. Exact username matching is used, for example, <c>alice</c>. When specified, delivery groups in which all applications have been directly authorized to this user are excluded. If this parameter is not specified or is set to an empty string, no exclusion based on user authorization is applied.</para>
        /// <para><b>Authorization granted for individual applications only, or access permissions obtained through user groups, is not fully evaluated by this condition.</b> Do not treat the returned results as a complete list of delivery groups that the user has no access permissions to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("ExcludeUserId")]
        [Validation(Required=false)]
        public string ExcludeUserId { get; set; }

        /// <summary>
        /// <para>The page number. This parameter is required. Start from page <c>1</c> and use this parameter together with <c>PageSize</c>. Keep other filter conditions unchanged when querying subsequent pages.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of delivery groups to return per page. This parameter is required. Valid values: <c>1</c> to <c>100</c>. Unit: delivery groups. Specify this value explicitly and do not rely on default values from other query operations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. This parameter is required. The value must match the product type of the delivery groups you want to query. Only published delivery groups of the specified product type are returned. A parameter error is returned if an unrecognized value is passed in.</para>
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
