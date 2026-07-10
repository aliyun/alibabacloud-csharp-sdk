// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned application information.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// <para>The status of the Developer API feature for the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("ApiInvokeStatus")]
            [Validation(Required=false)]
            public string ApiInvokeStatus { get; set; }

            /// <summary>
            /// <para>The application creation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("ApplicationCreationType")]
            [Validation(Required=false)]
            public string ApplicationCreationType { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The application identity type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>application: Application.</description></item>
            /// <item><description>agent: Agent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>application</para>
            /// </summary>
            [NameInMap("ApplicationIdentityType")]
            [Validation(Required=false)]
            public string ApplicationIdentityType { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML application</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            [NameInMap("ApplicationOwner")]
            [Validation(Required=false)]
            public GetApplicationResponseBodyApplicationApplicationOwner ApplicationOwner { get; set; }
            public class GetApplicationResponseBodyApplicationApplicationOwner : TeaModel {
                [NameInMap("GroupIds")]
                [Validation(Required=false)]
                public List<string> GroupIds { get; set; }

                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

            /// <summary>
            /// <para>The source from which the application was created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>urn:alibaba:idaas:app:source:template: Application template.</description></item>
            /// <item><description>urn:alibaba:idaas:app:source:standard: Standard protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:app:source:template</para>
            /// </summary>
            [NameInMap("ApplicationSourceType")]
            [Validation(Required=false)]
            public string ApplicationSourceType { get; set; }

            /// <summary>
            /// <para>The ID of the application template associated during creation. This value is returned only when the application was created from an application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt_rpa_tdsxxx</para>
            /// </summary>
            [NameInMap("ApplicationTemplateId")]
            [Validation(Required=false)]
            public string ApplicationTemplateId { get; set; }

            /// <summary>
            /// <para>The application visibility.</para>
            /// </summary>
            [NameInMap("ApplicationVisibility")]
            [Validation(Required=false)]
            public List<string> ApplicationVisibility { get; set; }

            /// <summary>
            /// <para>The access authorization type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>authorize_required: Explicit authorization is required for access.</description></item>
            /// <item><description>default_all: All members have access permissions by default.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>authorize_required</para>
            /// </summary>
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            /// <summary>
            /// <para>The client ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The time when the application was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("CustomFields")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyApplicationCustomFields> CustomFields { get; set; }
            public class GetApplicationResponseBodyApplicationCustomFields : TeaModel {
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("FieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the custom Subject field in the token is enabled. After this feature is enabled, the issued Access Token changes from \&lt;clientId\&gt; to \&lt;clientId\&gt;:\&lt;client.activeSubjectUrn\&gt;, where client.activeSubjectUrn is configured in the attribute mapping of the federated identity credential of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("CustomSubjectStatus")]
            [Validation(Required=false)]
            public string CustomSubjectStatus { get; set; }

            /// <summary>
            /// <para>The application description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An application for test environment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The features supported by the application, returned as a JSON array string. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>sso: Single sign-on.</description></item>
            /// <item><description>provision: Account synchronization.</description></item>
            /// <item><description>api_invoke: API access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;sso&quot;, &quot;provision&quot;]</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public string Features { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The URL of the application logo.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01lvYwpv1aGowQXDML9_!!6000000003303-0-tps-580-580.jpg">https://img.alicdn.com/imgextra/i4/O1CN01lvYwpv1aGowQXDML9_!!6000000003303-0-tps-580-580.jpg</a></para>
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>The M2MClient status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("M2MClientStatus")]
            [Validation(Required=false)]
            public string M2MClientStatus { get; set; }

            /// <summary>
            /// <para>The ServiceCode of the cloud service that manages the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rpa</para>
            /// </summary>
            [NameInMap("ManagedServiceCode")]
            [Validation(Required=false)]
            public string ManagedServiceCode { get; set; }

            /// <summary>
            /// <para>The unique identifier of the ResourceServer, which corresponds to the ResourceServer audience.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com">https://www.example.com</a></para>
            /// </summary>
            [NameInMap("ResourceServerIdentifier")]
            [Validation(Required=false)]
            public string ResourceServerIdentifier { get; set; }

            /// <summary>
            /// <para>The resource server source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:cloud:idaas:resourceserver:source:custom</para>
            /// </summary>
            [NameInMap("ResourceServerSourceType")]
            [Validation(Required=false)]
            public string ResourceServerSourceType { get; set; }

            /// <summary>
            /// <para>The ResourceServer status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ResourceServerStatus")]
            [Validation(Required=false)]
            public string ResourceServerStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the application template is managed by a cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            [NameInMap("SmartConfigCapabilities")]
            [Validation(Required=false)]
            public List<string> SmartConfigCapabilities { get; set; }

            /// <summary>
            /// <para>The single sign-on protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>saml2: SAML 2.0 protocol.</description></item>
            /// <item><description>oidc: OpenID Connect protocol.</description></item>
            /// <item><description>oauth2/m2m: OAuth 2.0 protocol.</description></item>
            /// <item><description>oidc+oauth2/m2m: OpenID Connect and OAuth 2.0 protocols.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>saml2</para>
            /// </summary>
            [NameInMap("SsoType")]
            [Validation(Required=false)]
            public string SsoType { get; set; }

            /// <summary>
            /// <para>The application status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the application was last updated. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
