// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedUsersRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. This parameter is used to filter users who are <b>specifically authorized for this application</b> (authorized through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation). This parameter applies to app instance groups whose authorization mode is <c>App</c>. You can obtain the application ID from the Apps list returned by the <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a> operation.</para>
        /// <para>If this parameter is not specified, all authorized users under the app instance group are returned. This parameter is not supported when querying by app instance group set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The app instance group ID. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID. For cloud browser groups, specify the browser group ID returned by the <a href="~~ListBrowserInstanceGroup~~">ListBrowserInstanceGroup</a> operation.</para>
        /// <para><b>You must specify either this parameter or AppInstanceGroupSetId, but not both.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The app instance group set ID.</para>
        /// <para><b>You must specify either this parameter or AppInstanceGroupId, but not both.</b> When querying by set, do not specify AppId or AppInstancePersistentId. Otherwise, a parameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstanceGroupSetId")]
        [Validation(Required=false)]
        public string AppInstanceGroupSetId { get; set; }

        /// <summary>
        /// <para>The persistent session ID. This parameter is used to filter users who are granted this persistent session. This parameter applies to app instance groups whose authorization mode is <c>Session</c>. You can call the <a href="~~ListPersistentAppInstances~~">ListPersistentAppInstances</a> operation to obtain the ID.</para>
        /// <para>If this parameter is specified, only the users granted this session are returned. However, the AppInstancePersistentIds response parameter still lists all persistent sessions granted to the user. This parameter is not supported when querying by app instance group set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cc7s3mw2fg4j****</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <para>The username. Performs <b>exact match</b> by username. If this parameter is not specified, filtering by full username is not applied. This parameter can be specified together with UserIdFuzzy, and both conditions must be met.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

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
        /// <para>The number of records returned per page. Valid values: 1 to 100.</para>
        /// <para>When the authorization mode is <c>App</c> or <c>AppInstanceGroup</c>, pagination is based on authorization records. Multiple authorization records for the same user are merged into one user in the response. Therefore, the actual number of users returned on the current page may be less than this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. The value must be consistent with the product type of the queried app instance group or app instance group set. If they are inconsistent, a resource not found error code is returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: Wuying Cloud App</description></item>
        /// <item><description>CloudBrowser: Cloud Browser</description></item>
        /// <item><description>WuyingServer: Enterprise Edition workstation</description></item>
        /// <item><description>WuyingWorkstation: Personal Edition Linggou container workstation</description></item>
        /// <item><description>WuyingWorkstationTeam: Team Edition Linggou container workstation</description></item>
        /// <item><description>WuyingWorkstationBusiness: Dedicated Edition Linggou container workstation</description></item>
        /// <item><description>AndroidCloud: Cloud Phone</description></item>
        /// <item><description>AIAgent: AgentBay (AI agent)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The username keyword. Performs <b>fuzzy match</b> by username. A hit occurs if the username contains this keyword. For example, if you specify <c>ali</c>, both <c>alice</c> and <c>ali.wang</c> are matched. If this parameter is not specified, filtering by keyword is not applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("UserIdFuzzy")]
        [Validation(Required=false)]
        public string UserIdFuzzy { get; set; }

    }

}
