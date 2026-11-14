// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedAppInstanceGroupByUserRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Fuzzy match is supported. App instance groups in which the IDs of deployed applications contain this string are returned. You can obtain the application ID from the Apps list returned by this operation.</para>
        /// <para>If this parameter is not specified, app instance groups are not filtered by application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The app instance group ID. Fuzzy match is supported. App instance groups whose IDs contain this string are returned. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID.</para>
        /// <para>If this parameter is not specified, app instance groups are not filtered by app instance group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The app instance group name. Fuzzy match is supported. For example, if you specify <c>Office applications</c>, app instance groups whose names contain <c>Office applications</c> (such as <c>My office applications</c> and <c>Office applications A</c>) are queried.</para>
        /// <para>If this parameter is not specified, app instance groups are not filtered by app instance group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The application name. Fuzzy match is supported. App instance groups in which the names of deployed applications contain this string are returned.</para>
        /// <para>If this parameter is not specified, app instance groups are not filtered by application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The username. Exact match is used based on the username to query the app instance groups to which the user has been granted app instance group-level authorization.</para>
        /// <remarks>
        /// <para>This parameter is required. If this parameter is not specified, the error code InvalidParameter.UserId is returned.</para>
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
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen+dir-436909****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of app instance groups to return on each page. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. The value must be consistent with the product type of the queried app instance groups. Only app instance groups of this product type are returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: Cloud App.</description></item>
        /// <item><description>CloudBrowser: Cloud Browser.</description></item>
        /// <item><description>WuyingServer: Enterprise Edition workstation.</description></item>
        /// <item><description>WuyingWorkstation: Personal Edition Linggou container workstation.</description></item>
        /// <item><description>WuyingWorkstationTeam: Team Edition Linggou container workstation.</description></item>
        /// <item><description>WuyingWorkstationBusiness: Exclusive Edition Linggou container workstation.</description></item>
        /// <item><description>AndroidCloud: Cloud Phone.</description></item>
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
