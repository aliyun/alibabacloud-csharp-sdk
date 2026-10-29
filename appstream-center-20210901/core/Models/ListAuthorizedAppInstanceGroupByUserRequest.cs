// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedAppInstanceGroupByUserRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Fuzzy match is supported. Delivery groups in which the IDs of deployed applications contain this string are returned. You can obtain the application ID from the Apps list returned by this operation.</para>
        /// <para>If this parameter is not specified, delivery groups are not filtered by application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery group ID. Fuzzy match is supported. Delivery groups whose IDs contain this string are returned. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID.</para>
        /// <para>If this parameter is not specified, delivery groups are not filtered by delivery group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group name. Fuzzy match is supported. For example, if you specify Office applications, delivery groups whose names contain Office applications (such as My office applications and Office applications A) are returned.</para>
        /// <para>If this parameter is not specified, delivery groups are not filtered by delivery group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The application name. Fuzzy match is supported. Delivery groups in which the names of deployed applications contain this string are returned.</para>
        /// <para>If this parameter is not specified, delivery groups are not filtered by application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office applications</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The username. Exact match is used to query the delivery groups for which the user has been granted delivery group-level authorization.</para>
        /// <remarks>
        /// <para>This parameter is required. If this parameter is not specified, the InvalidParameter.UserId error code is returned.</para>
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
        /// <para>The product type. The value must be the same as the product type of the delivery groups to be queried. Only delivery groups of this product type are returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: Wuying Cloud App.</description></item>
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
