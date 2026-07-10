// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application information.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
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
            /// <para>The application identity type.</para>
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
            /// <para>SAML Application</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The application creation source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>urn:alibaba:idaas:app:source:template: Application template.</description></item>
            /// <item><description>urn:alibaba:idaas:app:source:standard: Standard protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:app:source:standard</para>
            /// </summary>
            [NameInMap("ApplicationSourceType")]
            [Validation(Required=false)]
            public string ApplicationSourceType { get; set; }

            /// <summary>
            /// <para>The application template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt_xxx_xxx</para>
            /// </summary>
            [NameInMap("ApplicationTemplateId")]
            [Validation(Required=false)]
            public string ApplicationTemplateId { get; set; }

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
            /// <para>The time when the application was created, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The application description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A test application</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The features supported by the application, returned as a JSON array string. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>sso: Single sign-on.</description></item>
            /// <item><description>slo: Single logout.</description></item>
            /// <item><description>provision: Account synchronization.</description></item>
            /// <item><description>api_invoke: API access. </description></item>
            /// <item><description>m2m_client: M2M Client capability.</description></item>
            /// <item><description>resource_server: API service capability.</description></item>
            /// <item><description>other: Fallback.</description></item>
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
            /// <para>The ServiceCode of the Alibaba Cloud service that manages the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rpa</para>
            /// </summary>
            [NameInMap("ManagedServiceCode")]
            [Validation(Required=false)]
            public string ManagedServiceCode { get; set; }

            /// <summary>
            /// <para>The unique identifier of the ResourceServer.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com">https://example.com</a></para>
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
            /// <para>The resource server status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ResourceServerStatus")]
            [Validation(Required=false)]
            public string ResourceServerStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the application template is managed by an Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The single sign-on (SSO) logon protocol. Valid values:</para>
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
            /// <item><description>deleted: Soft deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the application was last updated, in UNIX timestamp format. Unit: milliseconds.</para>
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

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
