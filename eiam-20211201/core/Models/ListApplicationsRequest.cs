// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>system_init</para>
        /// </summary>
        [NameInMap("ApplicationCreationType")]
        [Validation(Required=false)]
        public string ApplicationCreationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("ApplicationIdentityType")]
        [Validation(Required=false)]
        public string ApplicationIdentityType { get; set; }

        /// <summary>
        /// <para>The IDs of the applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ram Account SSO</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The name of the application. Only fuzzy match from the leftmost character is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ram Account SSO</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The authorization of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>authorize_required: Only the user with explicit authorization can access the application.</description></item>
        /// <item><description>default_all: By default, all users can access the application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>authorize_required</para>
        /// </summary>
        [NameInMap("AuthorizationType")]
        [Validation(Required=false)]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Used to determine whether M2M client identity is enabled.</para>
        /// <list type="bullet">
        /// <item><description>enabled</description></item>
        /// <item><description>disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("M2MClientStatus")]
        [Validation(Required=false)]
        public string M2MClientStatus { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Used to determine whether the ResourceServer capability is enabled.</para>
        /// <list type="bullet">
        /// <item><description>enabled</description></item>
        /// <item><description>disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("ResourceServerStatus")]
        [Validation(Required=false)]
        public string ResourceServerStatus { get; set; }

        /// <summary>
        /// <para>SSO type.</para>
        /// <list type="bullet">
        /// <item><description>oidc</description></item>
        /// <item><description>saml2</description></item>
        /// <item><description>oauth2/m2m</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oauth2/m2m</para>
        /// </summary>
        [NameInMap("SsoType")]
        [Validation(Required=false)]
        public string SsoType { get; set; }

        /// <summary>
        /// <para>The status of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The application is enabled.</description></item>
        /// <item><description>Disabled: The application is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
