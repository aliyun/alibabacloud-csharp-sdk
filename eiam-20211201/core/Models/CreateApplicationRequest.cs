// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("ApplicationIdentityType")]
        [Validation(Required=false)]
        public string ApplicationIdentityType { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ram Account SSO</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The type of the application source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>urn:alibaba:idaas:app:source:template: application template</description></item>
        /// <item><description>urn:alibaba:idaas:app:source:standard: standard protocol</description></item>
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
        /// <para>The ID of the application template. This parameter is required if you set the ApplicationSourceType parameter to urn:alibaba:idaas:app:source:template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template_cloud_ram</para>
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM user SSO application</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
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
        /// <para>The SSO protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>saml2: the SAML 2.0 protocol.</description></item>
        /// <item><description>oidc: the OpenID Connect protocol.</description></item>
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
