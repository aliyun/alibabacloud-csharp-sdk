// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPublishedAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application used to filter delivery groups. Fuzzy match is supported. The delivery group must contain a deployed application that meets the condition. If this parameter is not specified or is set to an empty string, the results are not filtered by application ID. If this parameter is specified together with AppName, the same application must meet both conditions.</para>
        /// <para>This condition does not trim the returned Apps list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the delivery group used for filtering. Fuzzy match is supported. You can pass the complete ID or a contiguous segment of it. If this parameter is not specified or is set to an empty string, the results are not filtered by ID. This parameter can be used together with other filter conditions, and the results must meet all conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the delivery group used for filtering. Fuzzy match is supported. For example, if you pass Office applications, delivery groups whose names contain this text are matched. If this parameter is not specified or is set to an empty string, the results are not filtered by name. If this parameter is specified together with the delivery group ID, both the ID and the name must be matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The name of the application used to filter delivery groups. Fuzzy match is supported. The delivery group must contain a deployed application whose name contains the specified text. If this parameter is not specified or is set to an empty string, the results are not filtered by application name. If this parameter is specified together with AppId, the same application must meet both conditions.</para>
        /// <para>This condition does not trim the returned Apps list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The username to be excluded based on existing authorizations. Exact match by full username is supported, such as alice. After this parameter is specified, delivery groups for which all applications have been directly authorized to the user are excluded. If this parameter is not specified or is set to an empty string, the results are not excluded based on user authorization.</para>
        /// <para><b>Authorizations for a single application or access permissions obtained through user groups are not fully determined by this condition.</b> You cannot equate the returned results with a list of delivery groups to which the user has absolutely no access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("ExcludeUserId")]
        [Validation(Required=false)]
        public string ExcludeUserId { get; set; }

        /// <summary>
        /// <para>The ID of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing+dir-172301****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The page number. This parameter is required. Start the query from page 1 and use it in conjunction with PageSize. When querying subsequent pages, keep other filter conditions unchanged.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of delivery groups to return per page. This parameter is required. Valid values: 1 to 100. Unit: delivery groups. Explicitly specify this parameter and do not use the default values of other query operations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. This parameter is required. The value must be the same as the product type to which the delivery groups to be queried belong. Only published delivery groups under this product type are returned. If an unrecognized value is passed, a parameter error is returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: WUYING Cloud App.</description></item>
        /// <item><description>CloudBrowser: Cloud Browser.</description></item>
        /// <item><description>WuyingServer: Enterprise Edition workstation.</description></item>
        /// <item><description>WuyingWorkstation: Personal Edition Linggou container workstation.</description></item>
        /// <item><description>WuyingWorkstationTeam: Team Edition Linggou container workstation.</description></item>
        /// <item><description>WuyingWorkstationBusiness: Dedicated Edition Linggou container workstation.</description></item>
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
