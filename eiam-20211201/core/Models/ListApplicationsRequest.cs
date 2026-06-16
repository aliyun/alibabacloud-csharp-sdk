// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The application creation type. If unspecified, only user-created (<c>user_custom</c>) applications are returned. To query applications of all types, set this parameter to <c>all</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system_init</para>
        /// </summary>
        [NameInMap("ApplicationCreationType")]
        [Validation(Required=false)]
        public string ApplicationCreationType { get; set; }

        /// <summary>
        /// <para>The application identity type. If unspecified, only applications of the <c>application</c> type are returned. To query all identity types, set this parameter to <c>all</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("ApplicationIdentityType")]
        [Validation(Required=false)]
        public string ApplicationIdentityType { get; set; }

        /// <summary>
        /// <para>A list of application IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ram Account SSO</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The application name. Only prefix matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ram Account SSO</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The authorization type for application access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>authorize_required</c>: Access requires explicit authorization.</para>
        /// </description></item>
        /// <item><description><para><c>default_all</c>: All members have access by default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>authorize_required</para>
        /// </summary>
        [NameInMap("AuthorizationType")]
        [Validation(Required=false)]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// <para>A list of custom fields.</para>
        /// </summary>
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<ListApplicationsRequestCustomFields> CustomFields { get; set; }
        public class ListApplicationsRequestCustomFields : TeaModel {
            /// <summary>
            /// <para>The custom field identifier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>agent_type</c>: The agent type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>agent_type</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The custom field value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x-claw</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The status of the M2M client identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("M2MClientStatus")]
        [Validation(Required=false)]
        public string M2MClientStatus { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the resource server capability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("ResourceServerStatus")]
        [Validation(Required=false)]
        public string ResourceServerStatus { get; set; }

        /// <summary>
        /// <para>A filter for the Single Sign-On (SSO) type. You can specify multiple types, separated by a comma. Example: <c>oauth2/m2m,oidc+oauth2/m2m</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oauth2/m2m</para>
        /// </summary>
        [NameInMap("SsoType")]
        [Validation(Required=false)]
        public string SsoType { get; set; }

        /// <summary>
        /// <para>The application status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>enabled</c>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><c>disabled</c>: Disabled.</para>
        /// </description></item>
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
