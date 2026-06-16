// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The identity type of the application. The default value is application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>application: A standard application.</para>
        /// </description></item>
        /// <item><description><para>agent: An automated agent.</para>
        /// </description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ram Account SSO</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("ApplicationOwner")]
        [Validation(Required=false)]
        public CreateApplicationRequestApplicationOwner ApplicationOwner { get; set; }
        public class CreateApplicationRequestApplicationOwner : TeaModel {
            [NameInMap("GroupIds")]
            [Validation(Required=false)]
            public List<string> GroupIds { get; set; }

            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <para>Specifies how the application is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>urn:alibaba:idaas:app:source:template: Creates the application from an application template.</para>
        /// </description></item>
        /// <item><description><para>urn:alibaba:idaas:app:source:standard: Creates the application from a standard protocol.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:app:source:standard</para>
        /// </summary>
        [NameInMap("ApplicationSourceType")]
        [Validation(Required=false)]
        public string ApplicationSourceType { get; set; }

        /// <summary>
        /// <para>The ID of the application template. This parameter is required if ApplicationSourceType is urn:alibaba:idaas:app:source:template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apt_ramuser_mjqrsi</para>
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestCustomFields> CustomFields { get; set; }
        public class CreateApplicationRequestCustomFields : TeaModel {
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <para>The application description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM account SSO application</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk2676xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The URL of the application logo.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss.cn-hangzhou.aliyuncs.com/logo.png">https://oss.cn-hangzhou.aliyuncs.com/logo.png</a></para>
        /// </summary>
        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <para>The single sign-on (SSO) protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>saml2: SAML 2.0</para>
        /// </description></item>
        /// <item><description><para>oidc: OpenID Connect</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saml2</para>
        /// </summary>
        [NameInMap("SsoType")]
        [Validation(Required=false)]
        public string SsoType { get; set; }

    }

}
