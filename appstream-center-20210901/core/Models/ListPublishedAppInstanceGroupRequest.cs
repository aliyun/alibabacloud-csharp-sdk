// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPublishedAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application used to filter delivery groups. Partial matching is supported. The delivery group must contain a deployed application that meets the condition. If this parameter is not specified or is set to an empty string, the results are not filtered by application ID. If this parameter is specified together with <c>AppName</c>, both conditions must be met by the same application.</para>
        /// <para>This condition does not restrict the returned <c>Apps</c> list to the matched applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the delivery group used for filtering. Partial matching is supported. You can pass the complete ID or a continuous segment of it. If this parameter is not specified or is set to an empty string, the results are not filtered by ID. This parameter can be used together with other filter conditions, and the results must meet all conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the delivery group used for filtering. Partial matching is supported. For example, if you pass <c>Office applications</c>, delivery groups whose names contain this text are matched. If this parameter is not specified or is set to an empty string, the results are not filtered by name. If this parameter is specified together with the delivery group ID, both the ID and the name must be matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The name of the application used to filter delivery groups. Partial matching is supported. The delivery group must contain a deployed application whose name contains the specified text. If this parameter is not specified or is set to an empty string, the results are not filtered by application name. If this parameter is specified together with <c>AppId</c>, both conditions must be met by the same application.</para>
        /// <para>This condition does not restrict the returned <c>Apps</c> list to the matched applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The username to be excluded based on existing authorizations. Exact match by full username is supported, such as <c>alice</c>. If this parameter is specified, delivery groups for which all applications have been directly authorized to the user are excluded. If this parameter is not specified or is set to an empty string, the results are not filtered by user authorization status.</para>
        /// <para><b>Authorizations for a single application or access permissions obtained through user groups are not fully evaluated by this condition.</b> Do not equate the returned results with a list of delivery groups to which the user has no access at all.</para>
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
        /// <para>The page number. This parameter is required. Start the query from page <c>1</c> and use it in conjunction with <c>PageSize</c>. Keep other filter conditions unchanged when querying subsequent pages.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of delivery groups to return per page. This parameter is required. Valid values: <c>1</c> to <c>100</c>. Explicitly specify this parameter and do not use the default values of other query operations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. This parameter is required. The value must be the same as the product type of the delivery groups to be queried. Only published delivery groups of this product type are returned. If an unrecognized value is passed, a parameter error is returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: Wuying Cloud App.</description></item>
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
