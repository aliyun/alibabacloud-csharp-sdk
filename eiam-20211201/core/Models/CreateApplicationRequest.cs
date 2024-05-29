// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// The name of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The type of the application source. Valid values:
        /// 
        /// *   urn:alibaba:idaas:app:source:template: application template
        /// *   urn:alibaba:idaas:app:source:standard: standard protocol
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationSourceType")]
        [Validation(Required=false)]
        public string ApplicationSourceType { get; set; }

        /// <summary>
        /// The ID of the application template. This parameter is required if you set the ApplicationSourceType parameter to urn:alibaba:idaas:app:source:template.
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The URL of the application logo.
        /// </summary>
        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// The SSO protocol. Valid values:
        /// 
        /// *   saml2: the SAML 2.0 protocol.
        /// *   oidc: the OpenID Connect protocol.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SsoType")]
        [Validation(Required=false)]
        public string SsoType { get; set; }

    }

}
