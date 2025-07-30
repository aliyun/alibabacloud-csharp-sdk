// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML Application</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The origin of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>urn:alibaba:idaas:app:source:template: The application is created based on a template.</description></item>
            /// <item><description>urn:alibaba:idaas: The application is created based on the standard protocol.</description></item>
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
            /// <para>The time when the application was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A single application. The code is pkces.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The features that are supported by the application. The value is a JSON array. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>sso: The application supports SSO.</description></item>
            /// <item><description>slo: The application supports SLO.</description></item>
            /// <item><description>provision: The application supports account synchronization.</description></item>
            /// <item><description>api_invoke: The application supports custom APIs.</description></item>
            /// <item><description>m2m_client: The application supports M2M Client.</description></item>
            /// <item><description>resource_server: The application supports Resource Server.</description></item>
            /// <item><description>other: undertake.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;sso&quot;,&quot;slo&quot;, &quot;provision&quot;,&quot;api_invoke&quot;, &quot;m2m_client&quot;,&quot;resource_server&quot;,&quot;other&quot;]</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public string Features { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The URL of the application icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01lvYwpv1aGowQXDML9_!!6000000003303-0-tps-580-580.jpg">https://img.alicdn.com/imgextra/i4/O1CN01lvYwpv1aGowQXDML9_!!6000000003303-0-tps-580-580.jpg</a></para>
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>The service code of the cloud service that manages the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rpa</para>
            /// </summary>
            [NameInMap("ManagedServiceCode")]
            [Validation(Required=false)]
            public string ManagedServiceCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the application template is managed by a cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The type of the single sign-on (SSO) protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>saml2: the Security Assertion Markup Language (SAML) 2.0 protocol.</description></item>
            /// <item><description>oidc: the OpenID Connect (OIDC) protocol.</description></item>
            /// <item><description>oauth2/m2m: the OAuth2.0  protocol M2M.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>saml2</para>
            /// </summary>
            [NameInMap("SsoType")]
            [Validation(Required=false)]
            public string SsoType { get; set; }

            /// <summary>
            /// <para>The status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: The application is enabled.</description></item>
            /// <item><description>disabled: The application is disabled.</description></item>
            /// <item><description>deleted: The application is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the application was last updated. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
