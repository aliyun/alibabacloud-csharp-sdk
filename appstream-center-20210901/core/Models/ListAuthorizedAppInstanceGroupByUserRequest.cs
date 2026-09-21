// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedAppInstanceGroupByUserRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Fuzzy matching is supported: delivery groups that contain a deployed application whose ID includes the specified string are returned. You can obtain the application ID from the Apps list returned by this operation.</para>
        /// <para>If this parameter is not specified, no filtering by application ID is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery group ID. Fuzzy matching is supported: delivery groups whose IDs contain the specified string are returned. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the delivery group ID.</para>
        /// <para>If this parameter is not specified, no filtering by delivery group ID is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group name. Fuzzy matching is supported. For example, if you set this parameter to <c>Office App</c>, delivery groups whose names contain <c>Office App</c> (such as <c>My Office App</c> or <c>Office App A</c>) are returned.</para>
        /// <para>If this parameter is not specified, no filtering by delivery group name is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office App</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The application name. Fuzzy matching is supported: delivery groups that contain a deployed application whose name includes the specified string are returned.</para>
        /// <para>If this parameter is not specified, no filtering by application name is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office App</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The username. An <b>exact match</b> is performed on the username to query the delivery groups for which the user has been granted delivery group-level authorization.</para>
        /// <remarks>
        /// <para>This parameter is required. If this parameter is not specified, the error code <c>InvalidParameter.UserId</c> is returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of delivery groups to return per page. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. The value must match the product type of the delivery groups to query. Only delivery groups of the specified product type are returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: WUYING Cloud Application.</description></item>
        /// <item><description>CloudBrowser: cloud browser.</description></item>
        /// <item><description>WuyingServer: Enterprise Edition workstation.</description></item>
        /// <item><description>WuyingWorkstation: Personal Edition Lingjun container workstation.</description></item>
        /// <item><description>WuyingWorkstationTeam: Team Edition Lingjun container workstation.</description></item>
        /// <item><description>WuyingWorkstationBusiness: Dedicated Edition Lingjun container workstation.</description></item>
        /// <item><description>AndroidCloud: cloud phone.</description></item>
        /// <item><description>AIAgent: AgentBay (AI agent).</description></item>
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
