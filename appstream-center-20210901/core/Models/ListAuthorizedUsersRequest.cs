// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedUsersRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Specifies the application to filter users who are <b>authorized for that specific application</b> (authorized through the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation). This parameter applies to delivery groups with the <c>App</c> authorization mode. Obtain the application ID from the Apps list returned by the <a href="~~GetAppInstanceGroup~~">GetAppInstanceGroup</a> operation.</para>
        /// <para>If not specified, all authorized users under the delivery group are returned. This parameter is not supported when querying by delivery group set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery group ID. Call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain this value. For cloud browser groups, specify the browser group ID returned by the <a href="~~ListBrowserInstanceGroup~~">ListBrowserInstanceGroup</a> operation.</para>
        /// <para><b>Exactly one of this parameter and AppInstanceGroupSetId must be specified.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group set ID.</para>
        /// <para><b>Exactly one of this parameter and AppInstanceGroupId must be specified.</b> When querying by set, do not specify AppId or AppInstancePersistentId. Otherwise, a parameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstanceGroupSetId")]
        [Validation(Required=false)]
        public string AppInstanceGroupSetId { get; set; }

        /// <summary>
        /// <para>The persistent session ID. Specifies the persistent session to filter users who are granted that session. This parameter applies to delivery groups with the <c>Session</c> authorization mode. Call the <a href="~~ListPersistentAppInstances~~">ListPersistentAppInstances</a> operation to obtain this value.</para>
        /// <para>If specified, only users granted that session are returned. However, the response parameter AppInstancePersistentIds still lists all persistent sessions granted to each user. This parameter is not supported when querying by delivery group set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cc7s3mw2fg4j****</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <para>The username for <b>exact matching</b>. If not specified, no filtering by exact username is applied. Can be specified together with UserIdFuzzy, in which case both conditions must be met.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: 1 to 100.</para>
        /// <para>When the authorization mode is <c>App</c> or <c>AppInstanceGroup</c>, pagination is based on authorization records. Multiple authorization records for the same user are merged into a single user entry. Therefore, the actual number of users returned on the current page may be less than this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. The value must match the product type of the queried delivery group or delivery group set. If the value does not match, a resource-not-found error code is returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: Wuying Cloud Application.</description></item>
        /// <item><description>CloudBrowser: Cloud Browser.</description></item>
        /// <item><description>WuyingServer: Enterprise Edition Workstation.</description></item>
        /// <item><description>WuyingWorkstation: Personal Edition Linggou Container Workstation.</description></item>
        /// <item><description>WuyingWorkstationTeam: Linggou Team Edition Container Workstation.</description></item>
        /// <item><description>WuyingWorkstationBusiness: Linggou Dedicated Edition Container Workstation.</description></item>
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

        /// <summary>
        /// <para>The username keyword for <b>fuzzy matching</b>. A match occurs if the username contains this keyword. For example, if you specify <c>ali</c>, both <c>alice</c> and <c>ali.wang</c> are returned. If not specified, no keyword-based filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("UserIdFuzzy")]
        [Validation(Required=false)]
        public string UserIdFuzzy { get; set; }

    }

}
