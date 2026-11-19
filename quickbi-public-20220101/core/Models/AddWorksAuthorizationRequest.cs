// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddWorksAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The type of granted permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: View.</description></item>
        /// <item><description>3: View and export.</description></item>
        /// <item><description>11: Edit, view, and export.
        /// Note: When the value is set to 11, the authorization does not expire.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthPoints")]
        [Validation(Required=false)]
        public int? AuthPoints { get; set; }

        /// <summary>
        /// <para>The authorization scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: User. The AuthorizedId parameter corresponds to the user ID in Quick BI.</description></item>
        /// <item><description>1: User group. The AuthorizedId parameter corresponds to the user group ID in Quick BI.</description></item>
        /// <item><description>2: All organization members. The AuthorizedId parameter corresponds to the organization ID in Quick BI.</description></item>
        /// <item><description>3: All workspace members. The AuthorizedId parameter corresponds to the workspace ID in Quick BI.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthorizeScope")]
        [Validation(Required=false)]
        public int? AuthorizeScope { get; set; }

        /// <summary>
        /// <para>The ID of the authorized object. For more information, see the description of AuthorizeScope.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASDAS-WDAS****ASDA</para>
        /// </summary>
        [NameInMap("AuthorizedId")]
        [Validation(Required=false)]
        public string AuthorizedId { get; set; }

        /// <summary>
        /// <para>The expiration date of the authorization. Format: yyyy-MM-dd. Example: 2022-02-16. Note: The authorization period must be at least N+1 days. This parameter is required when the AuthPoints parameter is not set to 11.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2099-12-31</para>
        /// </summary>
        [NameInMap("ExpireDay")]
        [Validation(Required=false)]
        public string ExpireDay { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>al*************7ufv</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dashboard: Dashboard.</description></item>
        /// <item><description>report: Workbook.</description></item>
        /// <item><description>dashboardOfflineQuery: Ad hoc query.</description></item>
        /// <item><description>cube: Dataset.</description></item>
        /// <item><description>datasource: Data source.</description></item>
        /// <item><description>screen: Data screen.</description></item>
        /// <item><description>ANALYSIS: Ad hoc analysis.</description></item>
        /// <item><description>dataForm: Data entry.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dashboard</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
