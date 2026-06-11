// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddWorksAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The permissions to grant. Valid values:</para>
        /// <para><c>1</c>: View</para>
        /// <para><c>3</c>: View and Export</para>
        /// <para><c>11</c>: Edit, View, and Export</para>
        /// <para><b>Note</b>: If AuthPoints is set to 11, the authorization is permanent and the ExpireDay parameter is ignored.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthPoints")]
        [Validation(Required=false)]
        public int? AuthPoints { get; set; }

        /// <summary>
        /// <para>The type of the principal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: User. Set AuthorizedId to the user ID.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: User group. Set AuthorizedId to the user group ID.</para>
        /// </description></item>
        /// <item><description><para><c>2</c>: All members of an organization. Set AuthorizedId to the organization ID.</para>
        /// </description></item>
        /// <item><description><para><c>3</c>: All members of a workspace. Set AuthorizedId to the workspace ID.</para>
        /// </description></item>
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
        /// <para>The ID of the principal to be authorized. The AuthorizeScope parameter specifies the type of principal.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASDAS-WDAS****ASDA</para>
        /// </summary>
        [NameInMap("AuthorizedId")]
        [Validation(Required=false)]
        public string AuthorizedId { get; set; }

        /// <summary>
        /// <para>The expiration date for the permissions.</para>
        /// <para>Format: <c>YYYY-MM-DD</c>.</para>
        /// <para><b>Note</b>: This parameter is required if AuthPoints is not 11. The authorization must be valid for at least one day after the authorization date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2099-12-31</para>
        /// </summary>
        [NameInMap("ExpireDay")]
        [Validation(Required=false)]
        public string ExpireDay { get; set; }

        /// <summary>
        /// <para>The ID of the work.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>al*************7ufv</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the work. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>dashboard</c>: A dashboard.</para>
        /// </description></item>
        /// <item><description><para><c>report</c>: A report.</para>
        /// </description></item>
        /// <item><description><para><c>dashboardOfflineQuery</c>: An ad-hoc query.</para>
        /// </description></item>
        /// <item><description><para><c>cube</c>: A dataset.</para>
        /// </description></item>
        /// <item><description><para><c>datasource</c>: A data source.</para>
        /// </description></item>
        /// <item><description><para><c>screen</c>: A data screen.</para>
        /// </description></item>
        /// <item><description><para><c>ANALYSIS</c>: An ad-hoc analysis.</para>
        /// </description></item>
        /// <item><description><para><c>dataForm</c>: A data form.</para>
        /// </description></item>
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
